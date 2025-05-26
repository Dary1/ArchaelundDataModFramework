using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace ArchaelundDataModFramework
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    public class ArchaelundDataModFrameworkPlugin : BaseUnityPlugin
    {
        public const string PluginGUID = "com.modding.archaelunddatamodframework";
        public const string PluginName = "Archaelund Data Mod Framework";
        public const string PluginVersion = "1.0.0";

        private static ManualLogSource Logger;
        private static List<ReplacementConfig> AllConfigs = new List<ReplacementConfig>();
        private static ArchaelundDataModFrameworkPlugin Instance;
        private static string PluginDirectory;

        // BepInEx Configuration (cleaner than JSON config file)
        private static ConfigEntry<bool> EnableDebugLogging;
        private static ConfigEntry<bool> ValidateOldValues;

        public void Awake()
        {
            Instance = this;
            Logger = base.Logger;

            // Get the plugin's directory path
            PluginDirectory = Path.GetDirectoryName(Info.Location);

            // Setup BepInEx configuration - set defaults to true for easier testing
            EnableDebugLogging = Config.Bind("General", "EnableDebugLogging", true, "Show detailed logging for data modifications");
            ValidateOldValues = Config.Bind("General", "ValidateOldValues", false, "Validate expected old values before making changes");

            Logger.LogInfo($"Framework settings - Debug: {EnableDebugLogging.Value}, Validation: {ValidateOldValues.Value}");

            try
            {
                LoadAllMods();

                Logger.LogInfo("Applying Harmony patches...");
                var harmony = new Harmony(PluginGUID);
                harmony.PatchAll();
                Logger.LogInfo("Harmony patches applied successfully!");

                Logger.LogInfo($"{PluginName} loaded with {AllConfigs.Sum(c => c.fileReplacements.Count)} file configurations from {AllConfigs.Count} mods!");
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to initialize framework: {ex}");
            }
        }

        private void LoadAllMods()
        {
            // Only load from mods/ directory - much cleaner!
            string modsPath = Path.Combine(PluginDirectory, "mods");

            if (Directory.Exists(modsPath))
            {
                var jsonFiles = Directory.GetFiles(modsPath, "*.json", SearchOption.AllDirectories);

                foreach (var jsonFile in jsonFiles)
                {
                    try
                    {
                        string modName = Path.GetFileNameWithoutExtension(jsonFile);
                        LoadModConfig(jsonFile, modName);
                    }
                    catch (Exception ex)
                    {
                        Logger.LogError($"Failed to load mod config from {jsonFile}: {ex}");
                    }
                }
            }
            else
            {
                // Create the mods directory with an example
                Directory.CreateDirectory(modsPath);
                CreateExampleMod(modsPath);
            }
        }

        private void LoadModConfig(string configPath, string modName)
        {
            try
            {
                string configJson = File.ReadAllText(configPath);
                var config = JsonConvert.DeserializeObject<ModConfig>(configJson);

                if (config?.fileReplacements?.Count > 0)
                {
                    AllConfigs.Add(new ReplacementConfig
                    {
                        fileReplacements = config.fileReplacements,
                        globalSettings = new GlobalSettings
                        {
                            enableDebugLogging = EnableDebugLogging.Value,
                            validateOldValues = ValidateOldValues.Value
                        }
                    });

                    Logger.LogInfo($"Loaded mod '{modName}' with {config.fileReplacements.Count} file rules");

                    // List all files this mod will try to modify
                    foreach (var fileReplacement in config.fileReplacements)
                    {
                        Logger.LogInfo($"  - Will modify '{fileReplacement.fileName}' ({fileReplacement.replacements.Count} changes)");
                    }
                }
                else
                {
                    Logger.LogWarning($"Mod config '{modName}' contains no file replacements.");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to parse mod config '{modName}': {ex.Message}");
            }
        }

        private void CreateExampleMod(string modsPath)
        {
            var exampleMod = new ModConfig
            {
                fileReplacements = new List<FileReplacement>
                {
                    new FileReplacement
                    {
                        fileName = "items.txt",
                        delimiter = "\t",
                        idColumn = "ID",
                        replacements = new List<Replacement>
                        {
                            new Replacement
                            {
                                rowIdentifier = "iron_longsword",
                                columnName = "Price",
                                newValue = "25",
                                comment = "Example: Make iron longsword cheaper"
                            }
                        }
                    }
                }
            };

            string examplePath = Path.Combine(modsPath, "ExampleMod.json");
            string exampleJson = JsonConvert.SerializeObject(exampleMod, Formatting.Indented);
            File.WriteAllText(examplePath, exampleJson);
            Logger.LogInfo($"Created example mod at {examplePath}");
        }

        [HarmonyPatch(typeof(TextAsset), nameof(TextAsset.text), MethodType.Getter)]
        public static class TextAssetTextPatch
        {
            private static readonly Dictionary<TextAsset, string> _modifiedContent = new Dictionary<TextAsset, string>();

            static void Postfix(TextAsset __instance, ref string __result)
            {
                try
                {
                    // Check if we already processed this TextAsset
                    if (_modifiedContent.TryGetValue(__instance, out string cachedContent))
                    {
                        __result = cachedContent;
                        return;
                    }

                    // Try different naming patterns for Unity assets
                    string[] possibleNames = {
                        __instance.name + ".txt",
                        __instance.name,
                        Path.GetFileName(__instance.name) + ".txt",
                        Path.GetFileName(__instance.name)
                    };

                    // Only process if we have configuration for this asset
                    bool hasConfig = false;
                    foreach (var config in AllConfigs)
                    {
                        foreach (string fileName in possibleNames)
                        {
                            if (config.fileReplacements.Any(f =>
                                string.Equals(f.fileName, fileName, StringComparison.OrdinalIgnoreCase)))
                            {
                                hasConfig = true;
                                break;
                            }
                        }
                        if (hasConfig) break;
                    }

                    if (!hasConfig)
                    {
                        // Cache the original content to avoid repeated processing
                        _modifiedContent[__instance] = __result;
                        return;
                    }

                    if (EnableDebugLogging.Value)
                    {
                        Logger?.LogInfo($"Processing TextAsset: '{__instance.name}'");
                    }

                    string originalContent = __result;
                    string modifiedContent = originalContent;
                    bool wasModified = false;

                    foreach (string fileName in possibleNames)
                    {
                        if (ProcessFileIfNeeded(fileName, ref modifiedContent))
                        {
                            Logger?.LogInfo($"Successfully modified TextAsset '{__instance.name}' using filename '{fileName}'");
                            wasModified = true;
                            break;
                        }
                    }

                    // Cache the result (modified or original)
                    _modifiedContent[__instance] = modifiedContent;
                    __result = modifiedContent;

                    if (!wasModified && EnableDebugLogging.Value)
                    {
                        Logger?.LogInfo($"TextAsset '{__instance.name}' processed but no modifications made");
                    }
                }
                catch (Exception ex)
                {
                    Logger?.LogError($"Error in TextAsset.text patch for '{__instance?.name}': {ex}");
                    // Cache original content on error
                    if (__instance != null)
                    {
                        _modifiedContent[__instance] = __result;
                    }
                }
            }
        }

        private static bool ProcessFileIfNeeded(string fileName, ref string content)
        {
            bool modified = false;

            Logger?.LogInfo($"Checking if file '{fileName}' needs processing...");

            foreach (var config in AllConfigs)
            {
                var fileConfig = config.fileReplacements?.FirstOrDefault(f =>
                {
                    // Try exact match first
                    if (string.Equals(f.fileName, fileName, StringComparison.OrdinalIgnoreCase))
                        return true;

                    // Try without extension (Unity Resources often don't have extensions)
                    string fileNameWithoutExt = Path.GetFileNameWithoutExtension(f.fileName);
                    string targetNameWithoutExt = Path.GetFileNameWithoutExtension(fileName);
                    if (string.Equals(fileNameWithoutExt, targetNameWithoutExt, StringComparison.OrdinalIgnoreCase))
                        return true;

                    // Try adding .txt to the asset name
                    if (string.Equals(f.fileName, fileName + ".txt", StringComparison.OrdinalIgnoreCase))
                        return true;

                    return false;
                });

                if (fileConfig != null)
                {
                    Logger?.LogInfo($"Found configuration for {fileName} with {fileConfig.replacements.Count} replacements");
                    content = ProcessFileContent(content, fileConfig, fileName, config.globalSettings);
                    modified = true;
                }
            }

            if (!modified)
            {
                Logger?.LogInfo($"No configuration found for file: {fileName}");
            }

            return modified;
        }

        private static string ProcessFileContent(string content, FileReplacement fileConfig, string fileName, GlobalSettings settings)
        {
            try
            {
                if (EnableDebugLogging.Value)
                {
                    Logger.LogInfo($"Processing file: {fileName}");
                }

                // Preserve original line endings
                string[] lines = content.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                string originalLineEnding = content.Contains("\r\n") ? "\r\n" : content.Contains("\r") ? "\r" : "\n";

                if (lines.Length == 0) return content;

                // Find header line (first line that contains the idColumn or handle empty idColumn)
                int headerIndex = -1;
                string[] headers = null;
                int idColumnIndex = -1;

                for (int i = 0; i < lines.Length; i++)
                {
                    // Skip comment lines and section headers
                    if (lines[i].Trim().StartsWith("//") || lines[i].Trim().StartsWith("*") || string.IsNullOrWhiteSpace(lines[i]))
                        continue;

                    headers = lines[i].Split(new[] { fileConfig.delimiter }, StringSplitOptions.None);

                    // Handle empty idColumn (like armor.txt) - use first column
                    if (string.IsNullOrEmpty(fileConfig.idColumn))
                    {
                        idColumnIndex = 0;
                        headerIndex = i;
                        if (EnableDebugLogging.Value)
                            Logger?.LogInfo($"Using first column as ID column for {fileName}");
                        break;
                    }
                    // Normal case - find the specified ID column
                    else if (lines[i].Contains(fileConfig.idColumn))
                    {
                        idColumnIndex = Array.FindIndex(headers, h =>
                            string.Equals(h.Trim(), fileConfig.idColumn, StringComparison.OrdinalIgnoreCase));

                        if (idColumnIndex >= 0)
                        {
                            headerIndex = i;
                            if (EnableDebugLogging.Value)
                                Logger?.LogInfo($"Found ID column '{fileConfig.idColumn}' at index {idColumnIndex} in {fileName}");
                            break;
                        }
                    }
                }

                if (headerIndex == -1 || idColumnIndex == -1)
                {
                    Logger.LogWarning($"Could not find ID column '{fileConfig.idColumn}' in {fileName}");
                    return content; // Return original content unchanged
                }

                bool anyChanges = false;

                // Process replacements
                for (int i = headerIndex + 1; i < lines.Length; i++)
                {
                    string line = lines[i].Trim();
                    if (string.IsNullOrEmpty(line) || line.StartsWith("*") || line.StartsWith("//")) continue;

                    string[] columns = lines[i].Split(new[] { fileConfig.delimiter }, StringSplitOptions.None);
                    if (columns.Length <= idColumnIndex) continue;

                    string rowId = columns[idColumnIndex].Trim();
                    var replacement = fileConfig.replacements.FirstOrDefault(r =>
                        string.Equals(r.rowIdentifier, rowId, StringComparison.OrdinalIgnoreCase));

                    if (replacement != null)
                    {
                        int targetColumnIndex = Array.FindIndex(headers, h =>
                            string.Equals(h.Trim(), replacement.columnName, StringComparison.OrdinalIgnoreCase));

                        if (targetColumnIndex >= 0 && targetColumnIndex < columns.Length)
                        {
                            string oldValue = columns[targetColumnIndex].Trim();

                            // Validate old value if specified (skip validation if oldValue is empty/null)
                            if (ValidateOldValues.Value &&
                                !string.IsNullOrEmpty(replacement.oldValue) &&
                                !string.Equals(oldValue, replacement.oldValue, StringComparison.OrdinalIgnoreCase))
                            {
                                Logger.LogWarning($"Old value mismatch in {fileName}, row {rowId}, column {replacement.columnName}. Expected: '{replacement.oldValue}', Found: '{oldValue}'");
                                continue;
                            }

                            // Handle empty string replacements explicitly
                            string newValue = replacement.newValue ?? "";
                            columns[targetColumnIndex] = newValue;
                            lines[i] = string.Join(fileConfig.delimiter, columns);
                            anyChanges = true;

                            if (EnableDebugLogging.Value)
                            {
                                string oldValueDisplay = string.IsNullOrEmpty(oldValue) ? "(empty)" : $"'{oldValue}'";
                                string newValueDisplay = string.IsNullOrEmpty(newValue) ? "(empty)" : $"'{newValue}'";
                                Logger.LogInfo($"Replaced {fileName}[{rowId}].{replacement.columnName}: {oldValueDisplay} -> {newValueDisplay}");
                            }
                        }
                        else
                        {
                            Logger.LogWarning($"Column '{replacement.columnName}' not found in {fileName}");
                        }
                    }
                }

                // Only return modified content if we actually made changes
                if (anyChanges)
                {
                    return string.Join(originalLineEnding, lines);
                }
                else
                {
                    return content; // Return original unchanged
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"Error processing file content for {fileName}: {ex}");
                return content; // Return original content on error
            }
        }

        // Public API for advanced users to register configurations dynamically
        public static void RegisterConfiguration(ReplacementConfig config)
        {
            if (config?.fileReplacements?.Count > 0)
            {
                AllConfigs.Add(config);
                Logger?.LogInfo($"Dynamically registered configuration with {config.fileReplacements.Count} file rules.");
            }
        }
    }

    // Simplified mod config structure (no global settings in JSON)
    [Serializable]
    public class ModConfig
    {
        public List<FileReplacement> fileReplacements { get; set; } = new List<FileReplacement>();
    }

    // Keep these for internal use
    [Serializable]
    public class ReplacementConfig
    {
        public List<FileReplacement> fileReplacements { get; set; } = new List<FileReplacement>();
        public GlobalSettings globalSettings { get; set; } = new GlobalSettings();
    }

    [Serializable]
    public class FileReplacement
    {
        public string fileName { get; set; }
        public string delimiter { get; set; } = "\t";
        public string idColumn { get; set; }
        public List<Replacement> replacements { get; set; } = new List<Replacement>();
    }

    [Serializable]
    public class Replacement
    {
        public string rowIdentifier { get; set; }
        public string columnName { get; set; }
        public string newValue { get; set; }
        public string oldValue { get; set; }
        public string comment { get; set; }
    }

    [Serializable]
    public class GlobalSettings
    {
        public bool enableDebugLogging { get; set; } = false;
        public bool validateOldValues { get; set; } = false;
    }
}

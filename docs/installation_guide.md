# Archaelund Data Mod Framework - Complete Installation Guide

## Prerequisites: Install BepInEx First

### Step 1: Download BepInEx
1. Go to [BepInEx Releases](https://github.com/BepInEx/BepInEx/releases)
2. Download **BepInEx_x64_5.4.22.0.zip** (or latest 5.4.x version)
3. **DO NOT** download the "unix" or "x86" versions

### Step 2: Install BepInEx
1. **Navigate** to your Archaelund installation:
   ```
   YOUR STEAM LIBRARY\steamapps\common\Archaelund\
   ```
   
2. **Extract** the BepInEx zip directly into the Archaelund folder:
   ```
   YOUR STEAM LIBRARY\steamapps\common\Archaelund\
   ├── Archaelund.exe                    # Game executable
   ├── BepInEx\                          # ← Extract here
   │   ├── core\
   │   ├── plugins\                      # ← We'll use this folder
   │   └── config\
   ├── Archaelund_Data\
   └── ... (other game files)
   ```

3. **Launch** Archaelund once
   - BepInEx will initialize and create additional folders
   - You should see a console window appear briefly
   - Close the game after it loads

### Step 3: Verify BepInEx Installation
Check that these folders now exist:
```
YOUR STEAM LIBRARY\steamapps\common\Archaelund\
└── BepInEx\
    ├── plugins\          # ← Should exist now
    ├── config\           # ← Should exist now
    └── LogOutput.log     # ← Check this for errors
```

## Install Archaelund Data Mod Framework

### Step 4: Download the Framework
Get `ArchaelundDataModFramework.zip` from releases

### Step 5: Install the Framework
1. **Navigate** to your BepInEx plugins folder:
   ```
   YOUR STEAM LIBRARY\steamapps\common\Archaelund\BepInEx\plugins\
   ```

2. **Extract** the framework zip into the plugins folder:
   ```
   YOUR STEAM LIBRARY\steamapps\common\Archaelund\
   └── BepInEx\
       └── plugins\
           └── ArchaelundDataModFramework\    ← Extract here!
               ├── ArchaelundDataModFramework.dll
               └── mods\                      # (will be created)
   ```

### Step 6: Launch and Verify
1. **Launch** Archaelund
2. Check that the framework creates the mods folder:
   ```
   YOUR STEAM LIBRARY\steamapps\common\Archaelund\
   └── BepInEx\
       └── plugins\
           └── ArchaelundDataModFramework\
               ├── ArchaelundDataModFramework.dll
               └── mods\
                   └── ExampleMod.json        ← Auto-generated!
   ```

## Complete File Structure

After successful installation:
```
YOUR STEAM LIBRARY\steamapps\common\Archaelund\
├── Archaelund.exe
├── Archaelund_Data\
├── BepInEx\
│   ├── core\
│   ├── plugins\
│   │   └── ArchaelundDataModFramework\
│   │       ├── ArchaelundDataModFramework.dll    # The framework
│   │       └── mods\
│   │           ├── ExampleMod.json               # Auto-generated example
│   │           ├── YourBalanceMod.json           # Your mods go here
│   │           └── WeaponBuffs.json              # More mods
│   ├── config\
│   │   └── com.modding.archaelunddatamodframework.cfg  # Framework settings
│   └── LogOutput.log                             # Check for errors
└── ... (other game files)
```

## Adding Mods

Just drop `.json` files in the `mods/` folder:
```
YOUR STEAM LIBRARY\steamapps\common\Archaelund\BepInEx\plugins\ArchaelundDataModFramework\mods\
├── ExampleMod.json          # Auto-generated example
├── BalanceMod.json          # Your balance changes
├── WeaponBuffs.json         # Your weapon improvements
└── CareerTweaks.json        # Your career modifications
```

## Framework Settings

### Using BepInEx Configuration Manager (Recommended)
1. **Launch** the game
2. **Press F1** to open BepInEx config manager
3. **Find** "Archaelund Data Mod Framework" section
4. **Adjust** settings:
   - **Enable Debug Logging**: Show detailed modification logs
   - **Validate Old Values**: Check expected values before changes

### Manual Configuration (Advanced)
Edit the config file directly:
```
YOUR STEAM LIBRARY\steamapps\common\Archaelund\BepInEx\config\com.modding.archaelunddatamodframework.cfg
```

## Troubleshooting

### ❌ BepInEx Console Not Appearing?
- Verify you downloaded the x64 version
- Check that Archaelund.exe is in the same folder as BepInEx
- Look for errors in `BepInEx\LogOutput.log`

### ❌ Framework Not Loading?
- Ensure `ArchaelundDataModFramework.dll` is in the right location
- Check `BepInEx\LogOutput.log` for error messages
- Verify BepInEx is working with other plugins first

### ❌ Mods Not Working?
- Ensure `.json` files are in the `mods/` subfolder (not the main framework folder)
- Check JSON syntax with an online validator
- Enable debug logging to see what's happening

### ❌ Game Won't Start?
- Temporarily rename `BepInEx` folder to `BepInEx_disabled`
- If game works, the issue is with BepInEx installation
- Check BepInEx compatibility with your game version

## Finding Your Steam Library

### Method 1: Through Steam
1. **Right-click** Archaelund in Steam library
2. **Select** "Manage" → "Browse local files"
3. This opens your Archaelund installation folder

### Method 2: Manual Navigation
Common Steam library locations:
- **Windows**: `C:\Program Files (x86)\Steam\steamapps\common\Archaelund\`
- **Custom Drive**: `D:\SteamLibrary\steamapps\common\Archaelund\`
- **Multiple Libraries**: Steam → Settings → Downloads → Steam Library Folders

## Uninstalling

### Remove Framework Only:
Delete the `ArchaelundDataModFramework` folder:
```
YOUR STEAM LIBRARY\steamapps\common\Archaelund\BepInEx\plugins\ArchaelundDataModFramework\
```

### Remove Everything:
Delete the entire `BepInEx` folder:
```
YOUR STEAM LIBRARY\steamapps\common\Archaelund\BepInEx\
```

## Version Compatibility

- **BepInEx**: 5.4.x (tested with 5.4.22)
- **Archaelund**: All versions (framework uses runtime patching)
- **.NET Framework**: 4.6+ (usually pre-installed on Windows)

## Need Help?

1. **Check the logs** first: `BepInEx\LogOutput.log`
2. **Enable debug logging** for detailed information
3. **Test with just the example mod** to isolate issues
4. **Verify file paths** match exactly as shown in this guide

The framework makes Archaelund modding simple - once set up correctly, you just drop JSON files and play!

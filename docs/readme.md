# Archaelund Data Mod Framework

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![BepInEx](https://img.shields.io/badge/BepInEx-5.4.x-blue.svg)](https://github.com/BepInEx/BepInEx)
[![Archaelund](https://img.shields.io/badge/Archaelund-Early%20Access-green.svg)](https://store.steampowered.com/app/1082970/Archaelund/)

An unofficial modding framework for [Archaelund](https://store.steampowered.com/app/1082970/Archaelund/) that enables runtime modification of game data files. Built on the powerful [BepInEx](https://github.com/BepInEx/BepInEx) framework, this tool allows modders to create data-driven modifications without directly altering game files.

## ✨ Features

- **Runtime Data Modification**: Modify game data files during runtime without touching original files
- **Non-Destructive**: Keeps original game files intact while applying modifications
- **Developer-Friendly**: Easy-to-use API for creating data modification mods

## 📋 Requirements

- **Archaelund** (Steam Early Access version)
- **BepInEx 5.4.x** or higher
- **Windows 10+ ** (64-bit recommended)

## 🚀 Quick Start

### For Players (Installing Mods)

1. **Install BepInEx**:
   - Download BepInEx 5.4.x from the [official releases](https://github.com/BepInEx/BepInEx/releases)
   - Extract to your Archaelund game directory
   - Run the game once to initialize BepInEx

2. **Install the Framework**:
   - Download this repository from code -> download zip
   - Place ArchaelundDataModFramework under `BepInEx/plugins`
   - Launch Archaelund to verify installation

3. **Install Data Mods**:
   - Place compatible data mod directory in `BepInEx/plugins/ArchaelundDataModFramework/mods`   

### For Developers (Creating Mods)

[archaelund_game_db_documentation](archaelund_game_db_documentation.md)

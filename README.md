# FloatSensitivityPatch

A BepInEx plugin for **R.E.P.O** that enables full floating-point aim sensitivity values.  
REPO normally only allows integer values in its slider and config. This patch allow users to use any sensitivity by overriding the game’s input scaling logic using Harmony.

## Installation
1. Install [BepInEx 5](https://thunderstore.io/package/BepInEx/BepInExPack/)
2. Drop `FloatSensitivityPatch.dll` into your `BepInEx/plugins/` folder.
3. Launch the game to generate the config file.

## Configuration
Open `BepInEx/config/com.repo.floatsens.cfg` and edit the `AimSensitivity` value.

## License
MIT

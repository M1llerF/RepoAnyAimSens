# Building Instructions

1. Install [.NET Framework 4.8 Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48)
2. Open `src/FloatSensitivityPatch.csproj` in Visual Studio
3. Make sure references point to:
   - `BepInEx.dll`
   - `0Harmony.dll`
   - `UnityEngine.dll`
4. Build in Release mode. The DLL will be in `/bin/Release/net48/`

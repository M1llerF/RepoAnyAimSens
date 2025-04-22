using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

[BepInPlugin("com.repo.floatsens", "Float Sens Patch", "1.0.0")]
public class FloatSensPatch : BaseUnityPlugin
{
    // our float config
    internal static ConfigEntry<float> DesiredSens;

    private void Awake()
    {
        DesiredSens = Config.Bind(
            "General",
            "AimSensitivity",
            35.00f,
            "Set a true‑float aim sensitivity."
        );

        // apply all [HarmonyPatch]s in this assembly
        var harmony = new Harmony("com.repo.floatsens");
        harmony.PatchAll();
    }

    // Patch the game's UpdateAimSensitivity method wholesale
    [HarmonyPatch(typeof(GameplayManager), nameof(GameplayManager.UpdateAimSensitivity))]
    static class UpdateAimSensitivityPatch
    {
        // cache the private/internal field
        static readonly FieldInfo AimField = typeof(GameplayManager)
            .GetField("aimSensitivity", BindingFlags.Instance | BindingFlags.NonPublic);

        static bool Prefix(GameplayManager __instance)
        {
            // set the internal field via reflection
            AimField.SetValue(__instance, DesiredSens.Value);
            // skip the original (int‑based) method entirely
            return false;
        }
    }
}

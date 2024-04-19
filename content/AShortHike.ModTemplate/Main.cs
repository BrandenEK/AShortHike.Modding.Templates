using BepInEx;

namespace AShortHike.ModTemplate;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("AShortHike.ModdingAPI", "0.1.0")]
public class Main : BaseUnityPlugin
{
    public static ModTemplate ModTemplate { get; private set; }

    private void Awake()
    {
        ModTemplate = new ModTemplate();
    }
}

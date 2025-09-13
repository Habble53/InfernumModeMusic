using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernumModeMusic.MusicOverrides
{
    public class DukeFishronMusicHandler : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/DukeFishron");

        public override bool IsSceneEffectActive(Player player) => InfernumModeMusic.CanPlayMusic(NPCID.DukeFishron) && InfernumMusicConfig.Instance.OverrideDukeFishronTheme;

        public override SceneEffectPriority Priority => (SceneEffectPriority)10;
    }
}

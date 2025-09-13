using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernumModeMusic.MusicOverrides
{
    public class CultistMusicHandler : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/LunaticCultist");

        public override bool IsSceneEffectActive(Player player) => InfernumModeMusic.CanPlayMusic(NPCID.CultistBoss) && InfernumMusicConfig.Instance.OverrideLunaticCultistTheme;

        public override SceneEffectPriority Priority => (SceneEffectPriority)10;
    }
}

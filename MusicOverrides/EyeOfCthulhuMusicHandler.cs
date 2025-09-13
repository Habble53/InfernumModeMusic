using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace InfernumModeMusic.MusicOverrides
{
    public class EyeOfCthulhuMusicHandler : ModSceneEffect
    {
        public override int Music => MusicLoader.GetMusicSlot(Mod, "Sounds/Music/EyeOfCthulhu");

        public override bool IsSceneEffectActive(Player player) => InfernumModeMusic.CanPlayMusic(NPCID.EyeofCthulhu) && InfernumMusicConfig.Instance.OverrideEyeOfCthulhuTheme;

        public override SceneEffectPriority Priority => (SceneEffectPriority)10;
    }
}

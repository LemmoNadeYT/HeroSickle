using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	public class WalkingCactus : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Walking Cactus");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 68;
			npc.damage = 12;
			npc.defense = 4;
			npc.lifeMax = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 26;
			animationType = NPCID.Zombie;
		}
	}
}
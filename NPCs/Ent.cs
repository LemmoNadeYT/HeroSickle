using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	public class Ent : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wood Child's Minion");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 54;
			npc.damage = 12;
			npc.defense = 3;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 26;
			animationType = NPCID.Zombie;
		}
	}
}
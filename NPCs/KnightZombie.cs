using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	[AutoloadBossHead]
	public class KnightZombie : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zombie Knight");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Skeleton];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 20;
			npc.defense = 30;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
                        npc.boss = true;
                        bossBag = mod.ItemType("KnightBag");
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.001f;
}
        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                npc.DropBossBags();
            } else
            {
                if (Main.rand.Next(9) == 0) // For items that you want to have a chance to drop 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("LeadHeart"));
                }
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DarkLeadBar"), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HugeSword"));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HugeStabber"));
		}
	}
}
}

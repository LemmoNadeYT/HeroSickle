using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	[AutoloadBossHead]
	public class WoodKingHead : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wood King");
                        Main.npcFrameCount[npc.type] = 1;
		}

		public override void SetDefaults()
		{
			npc.width = 316;
                        npc.aiStyle = 320;
			npc.height = 102;
			npc.damage = 15;
			npc.defense = 10;
			npc.lifeMax = 1000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 44;
                        npc.boss = true;
                        bossBag = mod.ItemType("WoodBag");

                        }
        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                npc.DropBossBags();
            }
            {
                if (Main.rand.Next(9) == 0) // For items that you want to have a chance to drop 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WoodHeart"));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("WoodShield"));
                }
                if (Main.rand.Next(100) == 0) // For items that you want to have a chance to drop 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CheatMedal"));
                }

            }
		}
            }
        }

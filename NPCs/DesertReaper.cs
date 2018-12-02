using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	[AutoloadBossHead]
	public class DesertReaper : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Reaper");
			Main.npcFrameCount[npc.type] = 1;
		}
 
		public override void SetDefaults()
		{
			npc.width = 134;
			npc.height = 200;
			npc.damage = 65;
			npc.defense = 15;
			npc.lifeMax = 10000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0f;
                        npc.boss = true;
                        npc.noGravity = true;
                        bossBag = mod.ItemType("DesertBag");
                        npc.noTileCollide = true;
                        npc.aiStyle = 44;
                        npc.noTileCollide = true;
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
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CactusHeart"));
                }
                if (Main.rand.Next(100) == 0) // For items that you want to have a chance to drop 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CheatMedal"));
                }
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MultiCactus"), Main.rand.Next(16, 24));
            }
		}
            }
        }

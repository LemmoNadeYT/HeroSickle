using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	[AutoloadBossHead]
	public class CactiQueen : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cactus Guardian");
			Main.npcFrameCount[npc.type] = 1;
		}
 
		public override void SetDefaults()
		{
			npc.width = 134;
			npc.height = 200;
			npc.damage = 13;
			npc.defense = 2;
			npc.lifeMax = 2000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0f;
                        npc.boss = true;
                        npc.noGravity = true;
                        bossBag = mod.ItemType("CactiBag");
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
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CactiHeart"));
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CactiMagic"));
                }
                if (Main.rand.Next(100) == 0) // For items that you want to have a chance to drop 
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CheatMedal"));
                }
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CactiBar"), Main.rand.Next(3, 6));
            }
		}
            }
        }

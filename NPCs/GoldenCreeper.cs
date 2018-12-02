using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	[AutoloadBossHead]
	public class GoldenCreeper : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gilded Creeper");
			Main.npcFrameCount[npc.type] = 1;
		}
 
		public override void SetDefaults()
		{
			npc.width = 72;
			npc.height = 92;
			npc.damage = 100;
			npc.defense = 50;
			npc.lifeMax = 10000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0f;
                        npc.boss = true;
                        npc.noGravity = true;
                        bossBag = mod.ItemType("GoldenBag");
                        npc.aiStyle = 44;
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
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GoldHeart"));
                }
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PurifiedBar"), Main.rand.Next(9, 19));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SteelHorn"));
            }
		}
            }
        }

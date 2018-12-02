using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	public class CactiBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cactus Guardian's Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 2;
			item.expert = true;
			bossBagNPC = mod.NPCType("CactiQueen");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			if (Main.rand.Next(3) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("CactiHeart"));
			}
			if (Main.rand.Next(25) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("CheatMedal"));
			}
			player.QuickSpawnItem(mod.ItemType("CactiMagic"));
			player.QuickSpawnItem(mod.ItemType("CactiBar"), Main.rand.Next(5, 10));
		}
	}
}
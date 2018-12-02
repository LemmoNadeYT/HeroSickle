using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class BirthdayBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Birthday Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}\nDon't worry, It's not HeroSickle's Birthday!");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 2;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.QuickSpawnItem(mod.ItemType("CheatMedal"));
			player.QuickSpawnItem(mod.ItemType("CakeHeart"));
			player.QuickSpawnItem(mod.ItemType("BirthdayCandle"));
		}
	}
}
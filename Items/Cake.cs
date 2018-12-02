using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class Cake : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Cake");
			Tooltip.SetDefault("Hey look it's 'Cake'");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 1;
			item.maxStack = 99;
                        item.healLife = 3;
                        item.consumable = true;
			item.useAnimation = 7;
			item.useTime = 7;
			item.useStyle = 2;
		}
	}
}
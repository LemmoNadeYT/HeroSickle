using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
	public class SteelHorn : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Steel Horn");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 5;
			item.maxStack = 99;
                }
	}
}
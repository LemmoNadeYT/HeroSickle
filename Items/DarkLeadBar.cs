using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class DarkLeadBar : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Dark Lead Bar");
			Tooltip.SetDefault("It's dark lead...");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 1;
			item.maxStack = 99;
		}
	}
}
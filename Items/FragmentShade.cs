using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
	public class FragmentShade : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Shade Fragment");
			Tooltip.SetDefault("Endless despair resides within this fragment");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 9;
			item.maxStack = 999;
                }
	}
}
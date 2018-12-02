using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class MultiCactus : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Multi Coloured Cactus");
			Tooltip.SetDefault("Ooo colours!");
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
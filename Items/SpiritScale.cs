using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SpiritScale : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Spectre Scale");
			Tooltip.SetDefault("A scale from Haunted Armor!");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 8;
			item.maxStack = 99;
		}
	}
}
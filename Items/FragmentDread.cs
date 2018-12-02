using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
	public class FragmentDread : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Dread Fragment");
			Tooltip.SetDefault("You have a uneasy feeling around these...");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 10;
			item.maxStack = 999;
                }
	}
}
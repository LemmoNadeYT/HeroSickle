using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items.Cheat
{
	public class CheatMedal : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Cheat Medal");
			Tooltip.SetDefault("Used to craft Cheat Items\n 1/25 chance to drop from any HeroSickle boss in expert mode! 1/100 chance in normal mode! \n[c/f1a500:-Cheat Item-]");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = -11;
			item.maxStack = 99;
                }
	}
}
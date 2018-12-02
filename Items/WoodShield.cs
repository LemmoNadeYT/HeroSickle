using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class WoodShield : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Wood King's Shield");
			Tooltip.SetDefault("A shield made of Wood King's wood, weird!");
			item.expert = true;
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 5;
		}
	}
}
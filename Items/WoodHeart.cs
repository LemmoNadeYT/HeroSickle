using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class WoodHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Wooden Heart");
			Tooltip.SetDefault("+10 max life!");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 3;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.statLifeMax2 += 10;
		}
	}
}
using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CakeHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Delicious Heart");
			Tooltip.SetDefault("+15 max life!\nWait... why would you eat a heart?");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 3;
			item.accessory = true;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.statLifeMax2 += 15;
		}
	}
}
using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class GoldHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Heart of Gold");
			Tooltip.SetDefault("+40 max life!");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 8;
			item.accessory = true;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.statLifeMax2 += 40;
		}
	}
}
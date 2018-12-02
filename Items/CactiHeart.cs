using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CactiHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Cactus Heart");
			Tooltip.SetDefault("+40 max life\n-1 life regen");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
                        item.lifeRegen = -1;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.statLifeMax2 += 40;
		}
	}
}
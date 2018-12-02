using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CactiMagic : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Cactus Magic");
			Tooltip.SetDefault("+3% magic damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.magicDamage += 0.03f;
		}
	}
}
using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CorruptMagic : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Corrupt Magic");
			Tooltip.SetDefault("+7% magic damage\n+3% melee damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 5;
			item.accessory = true;
			item.expert = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.magicDamage += 0.07f;
			player.meleeDamage += 0.07f;
		}
	}
}
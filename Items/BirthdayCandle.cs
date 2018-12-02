using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class BirthdayCandle : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Birthday Candle");
			Tooltip.SetDefault("+5% all vanilla damage types!\n+5 Health!");
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
			player.meleeDamage += 0.05f;
			player.magicDamage += 0.05f;
			player.rangedDamage += 0.05f;
			player.thrownDamage += 0.05f;
                        player.statLifeMax2 += 5;
		}
	}
}
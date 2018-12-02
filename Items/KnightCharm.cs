using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class KnightCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Knight Zombie's Charm");
			Tooltip.SetDefault("+2% melee damage");
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
			player.meleeDamage += 0.02f;
		}
       }
}
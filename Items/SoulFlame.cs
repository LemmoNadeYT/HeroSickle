using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
	public class SoulFlame : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Soul Flame");
			Tooltip.SetDefault("What keeps people alive\nUseful for magic");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 22;
			item.value = 50;
			item.rare = 1;
			item.maxStack = 99;
                }
	}
}

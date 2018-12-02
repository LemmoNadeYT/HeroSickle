using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class TheDrumstick : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("The Drumstick");
			Tooltip.SetDefault("y..?");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 21;
			item.useAnimation = 21;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}

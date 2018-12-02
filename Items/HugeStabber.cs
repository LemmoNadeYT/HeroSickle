using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class HugeStabber : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Royal Stabber");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 3;
			item.knockBack = 1;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}

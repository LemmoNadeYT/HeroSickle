using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class HugeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Royal Sword");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}

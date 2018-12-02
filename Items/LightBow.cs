using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class LightBow : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Bow of Light");
			Tooltip.SetDefault("TOTALLY not stolen from Thorium Mod, and that other game...");
		}
		public override void SetDefaults()
		{
			item.damage = 135;
			item.ranged = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Arrow;
		}
	}
}

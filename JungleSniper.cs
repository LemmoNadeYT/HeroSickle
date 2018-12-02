using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class JungleSniper : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Jungle Sniper");
			Tooltip.SetDefault("A boring gun!");
		}
		public override void SetDefaults()
		{
			item.damage = 14;
			item.ranged = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Vine, 3);
                        recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

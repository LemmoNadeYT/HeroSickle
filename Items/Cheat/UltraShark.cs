using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Cheat
{
	public class UltraShark : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Big Boi");
			Tooltip.SetDefault("A request from my discord server!\n[c/f1a500:-Cheat Item-]");
		}
		public override void SetDefaults()
		{
			item.damage = 1234;
			item.ranged = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0;
			item.value = 10000;
			item.rare = -11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Bullet;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(null, "CheatMedal");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

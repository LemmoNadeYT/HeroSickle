using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SpiritShooter : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Spirit Shooter");
			Tooltip.SetDefault("Shoots homing Spectre Bolts!");
		}
		public override void SetDefaults()
		{
			item.damage = 70;
			item.ranged = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 8;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 297;
			item.shootSpeed = 9f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpiritScale", 6);
			recipe.AddIngredient(ItemID.SpectreBar, 6);
			recipe.AddIngredient(ItemID.Ectoplasm, 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
              }
	}
}

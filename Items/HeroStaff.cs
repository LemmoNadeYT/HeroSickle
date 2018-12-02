using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class HeroStaff: ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("HeroStaff");
			Tooltip.SetDefault("Shoots a mini HeroStaff");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 4331;
			item.magic = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.mana = 10;
                        item.shoot = mod.ProjectileType<HeroStaffP>();
			item.shootSpeed = 12f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(null, "TwinStaff");
                        recipe.AddIngredient(null, "GoldenStaff");
                        recipe.AddIngredient(null, "SecondReality");
                        recipe.AddIngredient(null, "NebulaBoomBox");
                        recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

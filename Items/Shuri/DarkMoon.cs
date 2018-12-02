using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class DarkMoon : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Dark Moon");
			Tooltip.SetDefault("Night's Shurikun?\nI just realised Fabu's Mod has something like this...");
		}

		public override void SetDefaults()
		{
			item.damage = 32;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 3);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 10;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<DarkMoonP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkLight");
			recipe.AddIngredient(null, "GrassyVine");
			recipe.AddIngredient(null, "Murashuri");
			recipe.AddIngredient(null, "ObsidianDemon");
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();

                        recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BloodCutter");
			recipe.AddIngredient(null, "GrassyVine");
			recipe.AddIngredient(null, "Murashuri");
			recipe.AddIngredient(null, "ObsidianDemon");
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

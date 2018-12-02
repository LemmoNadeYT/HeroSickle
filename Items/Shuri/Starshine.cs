using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class Starshine : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Shooting Star");
			Tooltip.SetDefault("'Shine bright like a star!'");
		}

		public override void SetDefaults()
		{
			item.damage = 104;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 22;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<StarshineP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FragmentConstellar", 18);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

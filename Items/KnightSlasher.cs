using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class KnightSlasher : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Knight's Stabber");
			Tooltip.SetDefault("I made it a shortshord!!!11!");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "KnightCharm");
			recipe.AddIngredient(null, "DarkLeadBar", 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
       }
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class DarkSword : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Dark Blade");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkLeadBar", 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

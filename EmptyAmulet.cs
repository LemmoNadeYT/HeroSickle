using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class EmptyAmulet : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Empty Amulet");
			Tooltip.SetDefault("It's empty...");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = -1;
			item.accessory = true;
			item.expert = true;
                }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 5);
                        recipe.AddTile(TileID.WorkBenches);

			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe.AddRecipe();
                        recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PlatinumBar, 5);
                        recipe.AddTile(TileID.WorkBenches);

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
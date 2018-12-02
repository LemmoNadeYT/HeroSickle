using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class OmegaHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Ultimate Heart");
			Tooltip.SetDefault("+290 max life!\nNo sprite yet!");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 6;
			item.accessory = true;
			item.defense = 3;
                        item.lifeRegen = -4;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.statLifeMax2 += 290;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GoldHeart");
			recipe.AddIngredient(null, "HallowedCactiHeart");
			recipe.AddIngredient(null, "CorruptCactiHeart");
			recipe.AddIngredient(null, "CrimsonCactiHeart");
			recipe.AddIngredient(null, "CrystalHeart");
			recipe.AddIngredient(null, "CactiHeart");
			recipe.AddIngredient(null, "WoodHeart");
			recipe.AddIngredient(null, "LeadHeart");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
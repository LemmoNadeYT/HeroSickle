using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CrimsonCactiHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Crimson Cactus Heart");
			Tooltip.SetDefault("+65 max life\n-3 life regen");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
                        item.lifeRegen = -3;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.statLifeMax2 += 65;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(null, "CactiHeart");
                        recipe.AddIngredient(null, "MultiCactus", 8);
                        recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
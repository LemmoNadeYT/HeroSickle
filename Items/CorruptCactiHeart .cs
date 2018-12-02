using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CorruptCactiHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Corrupt Cactus Heart");
			Tooltip.SetDefault("+50 max life\n-1 life regen");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
                        item.lifeRegen = -1;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.statLifeMax2 += 50;
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
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CrystalHeart : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Crystal Heart");
			Tooltip.SetDefault("+30 max life!");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 6;
			item.accessory = true;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.statLifeMax2 += 30;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 25);
			recipe.AddIngredient(ItemID.SoulofLight, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
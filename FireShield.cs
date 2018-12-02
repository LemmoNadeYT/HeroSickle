using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class FireShield : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Flame Shield");
			Tooltip.SetDefault("A shield made of hellstone!\nI don't get it...");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 4;
			item.accessory = true;
			item.defense = 6;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 7);
			recipe.AddIngredient(ItemID.AshBlock, 25);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
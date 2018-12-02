using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class LunarStabba : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Stabba");
			Tooltip.SetDefault("Strong enough to break the moon in half!");
		}
		public override void SetDefaults()
		{
			item.damage = 430;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 3;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HugeStabber");  recipe.AddIngredient(ItemID.FragmentSolar, 5); recipe.AddIngredient(ItemID.FragmentNebula, 5);	 recipe.AddIngredient(ItemID.FragmentVortex, 5); recipe.AddIngredient(ItemID.FragmentStardust, 5);		recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
	}
	}
}

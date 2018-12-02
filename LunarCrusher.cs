using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class LunarCrusher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Crusher");
			Tooltip.SetDefault("Strong enough to break the moon in half!");
		}
		public override void SetDefaults()
		{
			item.damage = 400;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HugeSword");
                        recipe.AddIngredient(ItemID.FragmentSolar, 8); 
                        recipe.AddIngredient(ItemID.FragmentNebula, 8);	
                        recipe.AddIngredient(ItemID.FragmentVortex, 8); 
                        recipe.AddIngredient(ItemID.FragmentStardust, 8);	
	                recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
	}
	}
}

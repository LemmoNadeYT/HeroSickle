using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class HeroSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("HeroSickle");
			Tooltip.SetDefault("lemmoNade's Sickle\nHey look, a description!");
		}
		public override void SetDefaults()
		{
			item.damage = 4331;
		        item.width = 200;
			item.height = 200;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
	                item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType<HeroSickleP>();
                        item.shootSpeed = 1;	
 }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                    	recipe.AddIngredient(null, "TerraSickle");
                        recipe.AddIngredient(null, "VoidCrusher"); 
                        recipe.AddIngredient(null, "ShadowBane"); 
                        recipe.AddIngredient(null, "BeetleSickle");
                        recipe.AddIngredient(null, "EarthSickle");  
                        recipe.AddTile(TileID.LunarCraftingStation);
	                recipe.SetResult(this);
	                recipe.AddRecipe(); 
}  
}}
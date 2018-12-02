using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class DawnDeath : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dawn's Death");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 95;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
	}

		public override void AddRecipes()
		{
	                ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DemoniteSickle");
                        recipe.AddIngredient(null, "JungleWrath");
                        recipe.AddIngredient(null, "WaterWave");
                        recipe.AddIngredient(null, "FlamingSickle");
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);

			recipe.AddRecipe();
                        recipe = new ModRecipe(mod);		
			recipe.AddIngredient(null, "CrimtaneSickle");
                        recipe.AddIngredient(null, "JungleWrath");
                        recipe.AddIngredient(null, "WaterWave");
                        recipe.AddIngredient(null, "FlamingSickle");
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
} 

}
}
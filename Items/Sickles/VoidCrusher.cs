using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class VoidCrusher : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void Crusher");
			Tooltip.SetDefault("Shoots Dark Energy that bounces!\nCould break the moon in half, just takes a while...");
		}
		public override void SetDefaults()
		{
			item.damage = 813;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 57;
			item.useAnimation = 57;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType<VoidCrusherP>();
                        item.shootSpeed = 7;	
}
		public override void AddRecipes()
		{
	                ModRecipe recipe = new ModRecipe(mod);
	                recipe.AddIngredient(null, "FragmentShade", 18);		
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
	 }
     }
}
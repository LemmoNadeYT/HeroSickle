using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class DreadScythe : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dread Scythe");
			Tooltip.SetDefault("Shoots a demon scythe like sickle");
		}
		public override void SetDefaults()
		{
			item.damage = 654;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 33;
			item.useAnimation = 33;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType<DreadScytheP>();
                        item.shootSpeed = 1;	
}
		public override void AddRecipes()
		{
	                ModRecipe recipe = new ModRecipe(mod);
	                recipe.AddIngredient(null, "FragmentDread", 10);	
	                recipe.AddIngredient(null, "ShadowBane");		
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
	 }
     }
}
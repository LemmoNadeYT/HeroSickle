using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class DespairBreaker : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Despair Breaker");
			Tooltip.SetDefault("Shoots Despair Balls");
		}
		public override void SetDefaults()
		{
			item.damage = 1103;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 52;
			item.useAnimation = 52;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType<DespairBreakerP>();
                        item.shootSpeed = 9;	
}
		public override void AddRecipes()
		{
	                ModRecipe recipe = new ModRecipe(mod);
	                recipe.AddIngredient(null, "FragmentDread", 10);
	                recipe.AddIngredient(null, "VoidCrusher");		
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
	 }
     }
}
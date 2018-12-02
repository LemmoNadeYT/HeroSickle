using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class ShadowBane : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Bane");
			Tooltip.SetDefault("Shoots a boomerang sickle that goes through walls!\nIt's so dark I can't hear anything!");
		}
		public override void SetDefaults()
		{
			item.damage = 542;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 38;
			item.useAnimation = 38;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType<ShadowBaneP>();
                        item.shootSpeed = 13;	
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
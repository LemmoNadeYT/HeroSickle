using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class TerraSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Sickle");
			Tooltip.SetDefault("A sickle of ultimate magic...\nShoots Terra Blade Swords!");
		}
		public override void SetDefaults()
		{
			item.damage = 208;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 55;
			item.useAnimation = 55;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		        item.shoot = 132;
                        item.shootSpeed = 10; }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TrueHallowLight");
	                recipe.AddIngredient(null, "TrueDawnDeath");
              		recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
.Sickles{
	public class EarthSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earth Sickle");
			Tooltip.SetDefault("Fires Staff of Earth boulders");
		}
		public override void SetDefaults()
		{
			item.damage = 120;
	item.width = 200;
			item.height = 200;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		item.shoot = 261;   item.shootSpeed = 10; }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BoulderSickle");
                       	recipe.AddIngredient(ItemID.StaffofEarth);
                        recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class SpectreSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectre Sickle");
			Tooltip.SetDefault("I think it's haunted by souls of the dungeon, how cheesy...");
		}
		public override void SetDefaults()
		{
			item.damage = 134;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		        item.shoot = 297; 
                        item.shootSpeed = 10; }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpectreBar, 10);
	                recipe.AddIngredient(ItemID.Ectoplasm, 5);
	                recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

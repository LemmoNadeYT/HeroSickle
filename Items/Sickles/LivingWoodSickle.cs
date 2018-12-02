using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class LivingWoodSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Living Wood Sickle");
			Tooltip.SetDefault("It's alive!");
		}
		public override void SetDefaults()
		{
			item.damage = 19;
			item.width = 200;
			item.height = 200;
			item.useTime = 50;
			item.useAnimation = 50;
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
		        recipe.AddIngredient(ItemID.Wood, 10);	 
                        recipe.AddTile(TileID.LivingLoom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

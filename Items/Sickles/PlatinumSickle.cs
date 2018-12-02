using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class PlatinumSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Platinum Sickle");
			Tooltip.SetDefault("Don't let the pirates steal this!");
		}
		public override void SetDefaults()
		{
			item.damage = 23;
			item.width = 200;
			item.height = 200;
			item.useTime = 50;
			item.useAnimation = 50;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		        recipe.AddIngredient(ItemID.PlatinumBar, 7);
                        recipe.AddIngredient(ItemID.Emerald, 1);
                        recipe.AddIngredient(ItemID.Wood, 5);
	                recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class IronSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Sickle");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 18;
			item.width = 200;
			item.height = 200;
			item.useTime = 49;
			item.useAnimation = 49;
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
		        recipe.AddIngredient(ItemID.IronBar, 7);
                        recipe.AddIngredient(ItemID.Wood, 5);	
                        recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

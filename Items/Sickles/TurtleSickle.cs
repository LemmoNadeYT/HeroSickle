using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class TurtleSickle : DeathItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Turtle Sickle");
			Tooltip.SetDefault("Sorry you had to farm for this ;~;");
		}
		public override void SetDefaults()
		{
			item.damage = 157;
			item.melee = true;
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
			recipe.AddIngredient(ItemID.TurtleShell, 1);
	                recipe.AddIngredient(ItemID.ChlorophyteBar, 4);		
                        recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

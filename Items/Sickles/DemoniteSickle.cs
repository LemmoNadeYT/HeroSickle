using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class DemoniteSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonite Sickle");
			Tooltip.SetDefault("A sickle of corrupted energy...");
		}
		public override void SetDefaults()
		{
			item.damage = 35;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 45;
			item.useAnimation = 45;
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
			recipe.AddIngredient(ItemID.DemoniteBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class WaterWave : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Water Wave");
			Tooltip.SetDefault("A sickle of magic water...");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
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
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenKey, 2);
			recipe.AddIngredient(ItemID.Bone, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

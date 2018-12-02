using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class HallowLight : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Light");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 114;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 52;
			item.useAnimation = 52;
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
			recipe.AddIngredient(ItemID.HallowedBar, 7);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class ReaperEdge : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reaper's Edge");
			Tooltip.SetDefault("A sickle used by the grim reaper, but it's broken!");
		}
		public override void SetDefaults()
		{
			item.damage = 24;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 41;
			item.useAnimation = 41;
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
			recipe.AddIngredient(null, "DarkLeadBar", 12);
                      	recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}


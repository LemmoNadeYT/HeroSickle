using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class KingSlimeSlasher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("King Slime's Slasher");
			Tooltip.SetDefault("A sword used by the ninja now stuck in King Slime...");
		}
		public override void SetDefaults()
		{
			item.damage = 19;
			item.melee = true;
			item.width = 2000;
			item.height = 2000;
			item.useTime = 20;
	item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
 }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
	recipe.AddIngredient(ItemID.Gel, 5);   recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

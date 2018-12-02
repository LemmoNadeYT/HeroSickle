using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class TrueReaperEdge : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Reaper's Edge");
			Tooltip.SetDefault("A true part of death it's self...");
		}
		public override void SetDefaults()
		{
			item.damage = 575;
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
	item.shoot = 156; item.shootSpeed = 10; }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 2);
	                recipe.AddIngredient(null, "ReaperEdge");
	                recipe.AddTile(TileID.MythrilAnvil);
	 		recipe.SetResult(this);
			recipe.AddRecipe();
		}
        }
}
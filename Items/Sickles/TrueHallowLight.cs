using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class TrueHallowLight : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Hallowed Light");
			Tooltip.SetDefault("A sickle of light, now upgraded!\nShoots True Excalibur Swords!");
		}
		public override void SetDefaults()
		{
			item.damage = 140;
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
		        item.shoot = 156;
                        item.shootSpeed = 10;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrokenHeroSword);
		        recipe.AddIngredient(null, "HallowLight");
	                recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

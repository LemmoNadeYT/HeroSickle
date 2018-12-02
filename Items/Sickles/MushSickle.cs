using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class MushSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shroomite Sickle");
			Tooltip.SetDefault("Kinda mushy...");
		}
		public override void SetDefaults()
		{
			item.damage = 125;
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
		        item.shoot = 131;
                        item.shootSpeed = 30;
                }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
	                recipe.AddTile(TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

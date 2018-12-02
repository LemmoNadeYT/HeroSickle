using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class CobaltSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cobalt Sickle");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 82;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 44;
			item.useAnimation = 44;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 12);
                     	recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
 }}
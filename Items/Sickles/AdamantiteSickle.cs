using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class AdamantiteSickle : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Sickle");
			Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			item.damage = 96;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 39;
			item.useAnimation = 39;
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
			recipe.AddIngredient(ItemID.AdamantiteBar, 12);
                     	recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
 }}
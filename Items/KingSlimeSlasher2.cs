using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class KingSlimeSlasher2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimed King Slime's Slasher");
			Tooltip.SetDefault("The ninja's sword, now covered in slime!");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 2000;
			item.height = 2000;
			item.useTime = 19;
	item.useAnimation = 19;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
 }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
	recipe.AddIngredient(ItemID.Gel, 5);   recipe.AddTile(TileID.Solidifier);
			recipe.SetResult(this);
			recipe.AddRecipe();
	} }}
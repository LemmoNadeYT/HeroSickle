using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class TrueDawnDeath : DeathItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Dawn's Death");
			Tooltip.SetDefault("A sickle of darkness, now upgraded!\nShoots True Night's Swords!");
		}
		public override void SetDefaults()
		{
			item.damage = 150;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
	                item.shoot = 157; 
                        item.shootSpeed = 10;	
}
		public override void AddRecipes()
		{
	                ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
	                recipe.AddIngredient(null, "DawnDeath");		
                        recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
	 }
     }
}
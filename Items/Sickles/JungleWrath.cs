using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class JungleWrath : DeathItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jungle Wrath");
			Tooltip.SetDefault("A sickle of the jungle...");
		}
		public override void SetDefaults()
		{
			item.damage = 46;
			item.width = 200;
			item.height = 200;
			item.useTime = 50;
			item.useAnimation = 50;
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
			recipe.AddIngredient(ItemID.JungleSpores, 3);
	                recipe.AddIngredient(ItemID.Stinger, 5);
                    	recipe.AddIngredient(ItemID.Vine, 1);
                      	recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

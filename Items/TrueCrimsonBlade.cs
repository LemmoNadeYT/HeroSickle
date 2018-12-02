using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class TrueCrimsonBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("True Crimson Blade");
			Tooltip.SetDefault("Fires a life stealing knife!");
		}

		public override void SetDefaults()
		{
			item.damage = 116;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 37;
			item.useAnimation = 37;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 10);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 304;
			item.shootSpeed = 12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrimsonBlade");
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

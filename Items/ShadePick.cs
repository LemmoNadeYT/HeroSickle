using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class ShadePick : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Shade Pickaxe");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 1;
			item.knockBack = 5.5f;
			item.value = Item.buyPrice(gold: 5);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.pick = 225;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(null, "FragmentShade", 12);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

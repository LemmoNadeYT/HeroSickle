using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class ConstellationHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Constellation Hamaxe");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = 1;
			item.knockBack = 7;
			item.value = Item.buyPrice(gold: 5);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.hammer = 100;
                        item.axe = 150;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "FragmentConstellar", 14);
			recipe.AddIngredient(ItemID.LunarBar, 12);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

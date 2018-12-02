using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SunsetSweep : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Sunset Sweep");
			Tooltip.SetDefault("A upgraded Arkhalis, so here?");
		}
		public override void SetDefaults()
		{
			item.damage = 215;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 5;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.knockBack = 4;
			item.value = 1000000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 595;
			item.shootSpeed = 8f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ItemID.Arkhalis);
                        recipe.AddIngredient(ItemID.FragmentSolar, 18);
                        recipe.AddIngredient(ItemID.LunarBar, 8);
                        recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
       }
}
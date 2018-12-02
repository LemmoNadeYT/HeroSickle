using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class HallowTree : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Gilded Lake");
			Tooltip.SetDefault("Shoots Purifying Powder");
		}

		public override void SetDefaults()
		{
			item.damage = 77;
			item.magic = true;
			item.mana = 4;
			item.width = 999;
			item.height = 999;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(gold: 3);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(null, "PurifiedBar", 8);
                        recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

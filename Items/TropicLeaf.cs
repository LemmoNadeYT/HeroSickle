using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class TropicLeaf : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Tropical Leaf");
			Tooltip.SetDefault("Shoots Purifying Powder");
		}

		public override void SetDefaults()
		{
			item.damage = 55;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(gold: 2);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 13;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Acorn, 5);
			recipe.AddIngredient(ItemID.PalmWood, 25);
			recipe.AddIngredient(ItemID.SoulofLight, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

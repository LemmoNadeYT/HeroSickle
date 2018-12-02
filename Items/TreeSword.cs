using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class TreeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Tree of Purity");
			Tooltip.SetDefault("Shoots Purifying Powder");
		}

		public override void SetDefaults()
		{
			item.damage = 53;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(gold: 2);
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Acorn, 5);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.AddIngredient(ItemID.SoulofLight, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

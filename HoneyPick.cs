using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class HoneyPick : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Honey Harvester");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(silver: 50);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.pick = 80;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BeeWax, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

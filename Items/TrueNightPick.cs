using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class TrueNightPick : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("True Shade Miner");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 48;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.pick = 205;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "NightPick");
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

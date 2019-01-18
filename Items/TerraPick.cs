using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class TerraPick : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Terra Miner");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = uhh;
			item.height = uhh;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 6.5;
			item.value = Item.buyPrice(gold: 20);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.pick = 210;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TrueNightMiner");
			recipe.AddIngredient(null, "TruePickAxe");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

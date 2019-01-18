using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class NightPick : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Shade Miner");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.pick = 115;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.NightmarePickaxe);
			recipe.AddIngredient(ItemID.BonePickaxe);
			recipe.AddIngredient(null, "HoneyPick");
			recipe.AddIngredient(ItemID.MoltenPickaxe);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

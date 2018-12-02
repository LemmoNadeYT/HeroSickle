using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CrimsonBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Crimson Blade");
			Tooltip.SetDefault("A blade of the crimson...");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BloodButcherer);
			recipe.AddIngredient(ItemID.FieryGreatsword);
			recipe.AddIngredient(ItemID.BladeofGrass);
			recipe.AddIngredient(ItemID.Muramasa);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

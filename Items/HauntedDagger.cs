using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class HauntedDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Haunted Dagger");
			Tooltip.SetDefault("Shoots homing Spectre Bolts!");
		}

		public override void SetDefaults()
		{
			item.damage = 122;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 3;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 297;
			item.shootSpeed = 9;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpiritScale", 5);
			recipe.AddIngredient(ItemID.SpectreBar, 4);
			recipe.AddIngredient(ItemID.Ectoplasm, 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

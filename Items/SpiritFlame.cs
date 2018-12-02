using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SpiritFlame : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Spirit Flame");
			Tooltip.SetDefault("Shoots homing Spectre Bolts!");
		}

		public override void SetDefaults()
		{
			item.damage = 104;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 297;
			item.shootSpeed = 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpiritScale", 7);
			recipe.AddIngredient(ItemID.SpectreBar, 5);
			recipe.AddIngredient(ItemID.Ectoplasm, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

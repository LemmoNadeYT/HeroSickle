using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class BloodBath : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Bloodbath");
			Tooltip.SetDefault("Night's Shurikun?\nI just realised Fabu's Mod has something NOT like this, OOOH!");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 3);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 12;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<BloodBathP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 8);
			recipe.AddIngredient(ItemID.HellstoneBar, 8);
			recipe.AddIngredient(ItemID.Stinger, 8);
			recipe.AddIngredient(ItemID.GoldenKey, 2);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

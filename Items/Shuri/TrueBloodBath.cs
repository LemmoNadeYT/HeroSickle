using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class TrueBloodBath : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("True Bloodbath");
			Tooltip.SetDefault("Night's Shurikun?\nI just realised Fabu's Mod has something NOT like this, OOOH!");
		}

		public override void SetDefaults()
		{
			item.damage = 88;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 3);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 15;
			item.maxStack = 999;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<TrueBloodBathP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BloodBath");
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

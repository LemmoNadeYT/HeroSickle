using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class TrueDarkMoon : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("True Dark Moon");
			Tooltip.SetDefault("Night's Shurikun?\nI just realised Fabu's Mod has something like this...");
		}

		public override void SetDefaults()
		{
			item.damage = 82;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 10);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 14;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<TrueDarkMoonP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkMoon");
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

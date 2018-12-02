using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Cheat
{
	public class SunriseSet : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Sunrise Sweep");
			Tooltip.SetDefault("A upgraded Arkhalis, so here?\n[c/f1a500:-Cheat Item-]");
		}
		public override void SetDefaults()
		{
			item.damage = 3015;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 5;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.knockBack = 9;
			item.value = 10000000;
			item.rare = -11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 595;
			item.shootSpeed = 20f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(null, "SunsetSweep");
			recipe.AddIngredient(null, "CheatMedal");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
       }
}
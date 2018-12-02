using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Cheat
{
	public class FingerBreaker : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Finger Breaker");
			Tooltip.SetDefault("It hurts to click... \n[c/f1a500:-Cheat Item-]");
		}

		public override void SetDefaults()
		{
			item.damage = 10010;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 4;
			item.useAnimation = 4;
			item.useStyle = 1;
			item.knockBack = 4;
			item.rare = -11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(null, "CheatMedal");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

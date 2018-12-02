using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class Note : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Boss Progression ~ HeroSickle");
			Tooltip.SetDefault("Wood King - Post EoC\nCactus Guardian - After Wood King\nDesert Reaper - Post Mec\nGuilded Creeper - Post Mec\nThanks for downloading HeroSickle!");

		}

		public override void SetDefaults()
		{
			item.width = 99;
			item.height = 99;
			item.expert = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.SetResult(this);
			recipe.AddRecipe();
	}
}
}

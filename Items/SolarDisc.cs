using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SolarDisc : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Solaric Disc");
			Tooltip.SetDefault("Oh yeah!");

		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.width = 99;
			item.height = 99;
			item.useAnimation = 15;
			item.useTime = 15;
			item.shootSpeed = 10f;
			item.knockBack = 3f;
			item.damage = 124;
			item.rare = 9;
			item.channel = true;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<SolarDiscP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ItemID.FragmentSolar, 8);
                       recipe.AddIngredient(ItemID.LightDisc);
                        recipe.AddTile(TileID.LunarCraftingStation);

			recipe.SetResult(this);
			recipe.AddRecipe();

        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 4;
	}
}
}

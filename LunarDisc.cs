using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class LunarDisc : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Lunaric Disc");
			Tooltip.SetDefault("Oh yeah even more!\nShoots 4!");

		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.width = 99;
			item.height = 99;
			item.useAnimation = 20;
			item.useTime = 20;
			item.shootSpeed = 30f;
			item.knockBack = 3f;
			item.damage = 113;
			item.rare = 9;
			item.channel = true;
			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 1);
			item.shoot = mod.ProjectileType<LunarDiscP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(null, "SolarDisc");
                        recipe.AddIngredient(ItemID.FragmentNebula, 8);
                        recipe.AddIngredient(ItemID.FragmentStardust, 8);
                        recipe.AddIngredient(ItemID.FragmentVortex, 8);
                        recipe.AddIngredient(ItemID.LunarBar, 8);
                        recipe.AddTile(TileID.LunarCraftingStation);

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 4 + Main.rand.Next(0);
			float rotation = MathHelper.ToRadians(10);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 5f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;

        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 16;
	}
}
}

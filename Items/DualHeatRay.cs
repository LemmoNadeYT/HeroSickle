using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class DualHeatRay : ModItem
	{
		public override void SetStaticDefaults()
		{       DisplayName.SetDefault("Upgraded Heat Ray");
			Tooltip.SetDefault("Don't say Oolaa! Say Oolala instead!");
		}

		public override void SetDefaults()
		{
			item.damage = 55;
			item.magic = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 260; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 15f;
                        item.mana = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HeatRay, 2);
			recipe.AddTile(TileID.LihzahrdAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2 + Main.rand.Next(0); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(10);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 5f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
       }
}
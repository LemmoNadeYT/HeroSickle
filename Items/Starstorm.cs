using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class Starstorm : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Sky Fury");
			Tooltip.SetDefault("Shoots stars!");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.shoot = 92;
                        item.shootSpeed = 30;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Starfury);
			recipe.AddIngredient(ItemID.MeteoriteBar, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2 + Main.rand.Next(3);
			float rotation = MathHelper.ToRadians(15);
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

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class Puri : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Puri");
			Tooltip.SetDefault("Purifies most of your world!\n[c/e10643:-Fun Item-]");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.useTime = 3;
			item.useAnimation = 3;
			item.useStyle = 1;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 145;
			item.shootSpeed = 100;
		}

public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 50 + Main.rand.Next(50); // 3, 4, or 5 shots
			float rotation = MathHelper.ToRadians(20);
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

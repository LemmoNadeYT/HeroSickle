using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class MetalGlove : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Metalic Glove");
			Tooltip.SetDefault("Shoots 2 bones!");
		}

		public override void SetDefaults()
		{
			item.damage = 44;
			item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = Item.buyPrice(gold: 1);
			item.expert = true;
                        item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.shoot = 532;
                        item.shootSpeed = 30;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BoneGlove);
			recipe.AddIngredient(ItemID.MechanicalBatteryPiece);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2 + Main.rand.Next(0);
			float rotation = MathHelper.ToRadians(10);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 10f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
}
	}
}

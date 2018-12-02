using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class DemonStereo : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Demon's Stereo");
			Tooltip.SetDefault("Shoots a circle of 36 notes around you");
		}
		public override void SetDefaults()
		{
			item.damage = 36;
			item.width = 999;
			item.height = 999;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 4;
			item.knockBack = 0;
			item.value = 1000;
			item.rare = 3;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
                        item.shoot = 77;
			item.shootSpeed = 25f;
			item.reuseDelay = 40;
		
}
public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 36 + Main.rand.Next(0);
			float rotation = MathHelper.ToRadians(360);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 0f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Stereo");
			recipe.AddIngredient(ItemID.HellstoneBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
       }
}
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class GoldenStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Golden Rain");
			Tooltip.SetDefault("Shoots 2 Ichor Streams!");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 26;
			item.magic = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 110000;
			item.rare = 8;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.mana = 5;
			item.shoot = 280;
			item.shootSpeed = 45f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(null, "PurifiedBar", 8);
                        recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 2 + Main.rand.Next(0);
			float rotation = MathHelper.ToRadians(5);
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

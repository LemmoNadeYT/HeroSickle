using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SecondReality : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Second Reality");
			Tooltip.SetDefault("Summons up to 6 Sky Swords!");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 82;
			item.magic = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 1000000;
			item.rare = 11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.mana = 9;
			item.shoot = 660;
			item.shootSpeed = 55f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ItemID.SkyFracture);
                        recipe.AddIngredient(ItemID.FragmentNebula, 18);
                        recipe.AddIngredient(ItemID.LunarBar, 8);
                        recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		
}
public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 3 + Main.rand.Next(3);
			float rotation = MathHelper.ToRadians(15);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * -30f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}
       }
}
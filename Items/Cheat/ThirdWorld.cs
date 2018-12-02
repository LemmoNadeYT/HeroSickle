using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Cheat
{
	public class ThirdWorld : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Third World");
			Tooltip.SetDefault("Summons 5 - 20 Sky Swords!\n[c/f1a500:-Cheat Item-]");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 244;
			item.magic = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 7;
			item.useAnimation = 7;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 8;
			item.value = 10000000;
			item.rare = -11;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.mana = 9;
			item.shoot = 660;
			item.shootSpeed = 55f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(null, "SecondReality");
			recipe.AddIngredient(null, "CheatMedal");
			recipe.SetResult(this);
			recipe.AddRecipe();
		
}
public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			float numberProjectiles = 5 + Main.rand.Next(15);
			float rotation = MathHelper.ToRadians(20);
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
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class GrassyVine : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Grassy Vine");
			Tooltip.SetDefault("No vine, all grass... oh yeah and no stingers too...");
		}

		public override void SetDefaults()
		{
			item.damage = 23;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 11;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<GrassyVineP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Stinger, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class ShroomDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Shroom Dagger");
			Tooltip.SetDefault("Kinda looks like a candle, just me?");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = Item.buyPrice(copper: 10);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 8;
			item.maxStack = 999;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<ShroomDaggerP>();
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GlowingMushroom);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}

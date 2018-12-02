using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class Murashuri : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Murashuri");
			Tooltip.SetDefault("Kinda a wierd name...");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 6;
			item.useAnimation = 6;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = Item.buyPrice(gold: 3);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 9;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<MurashuriP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldenKey, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

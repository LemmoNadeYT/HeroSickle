using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class CobaltShuri : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Cobalt Shuriken");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 13;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<CobaltShuriP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

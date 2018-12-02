using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class OrichalcumShuri : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Orichalcum Shuriken");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 41;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 14;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<OrichalcumShuriP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OrichalcumBar, 8);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

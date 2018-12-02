using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SpiritKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Spirit Knife");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 85;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = Item.buyPrice(gold: 10);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 11;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<SpiritKnifeP>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpiritScale", 6);
			recipe.AddIngredient(ItemID.SpectreBar, 4);
			recipe.AddIngredient(ItemID.Ectoplasm, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

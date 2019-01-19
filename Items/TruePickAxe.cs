using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class TruePickAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("True Pickaxe Axe");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 32;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 17;
			item.useAnimation = 13;
			item.useStyle = 13;
			item.knockBack = 4.5f;
			item.value = Item.buyPrice(gold: 8);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.pick = 200;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2
			{
                                item.shoot = mod.ProjectileType<TruePickAxeP>();
                                item.shootSpeed = 10;
			}
			else
			{
                                item.shootSpeed = 20;
			}
			return base.CanUseItem(player);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PickaxeAxe);
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

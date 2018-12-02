using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class InfernoLance : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Chains of Hell");
			Tooltip.SetDefault("Shoots Inferno Fork projectiles!\nShoots faster with <right>");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 666;
			item.magic = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 45;
			item.useAnimation = 45;
			item.useStyle = 5;
			item.knockBack = 0;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.shoot = 295;
                        item.shootSpeed = 6;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.damage = 111;
				item.useTime = 8;
				item.useAnimation = 8;
			}
			else
			{
				item.damage = 666;
				item.useTime = 45;
				item.useAnimation = 45;
			}
			return base.CanUseItem(player);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.InfernoFork);
			recipe.AddIngredient(ItemID.HellstoneBar, 7);
                        recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

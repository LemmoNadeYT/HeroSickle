using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class AquaMiracle : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Aqua of Miracle");
			Tooltip.SetDefault("Shoots a stream of water!\nShoots Razorblade Typhoons with <right>");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 234;
			item.melee = true;
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
                        item.shoot = 22;
                        item.shootSpeed = 20;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.damage = 234;
				item.useTime = 21;
				item.useAnimation = 21;
                                item.shoot = 409;
                                item.shootSpeed = 6;
			}
			else
			{
				item.damage = 234;
				item.useTime = 7;
				item.useAnimation = 7;
                                item.shoot = 22;
                                item.shootSpeed = 20;
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

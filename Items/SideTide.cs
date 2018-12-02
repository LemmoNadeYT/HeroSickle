using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SideTide : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Side Tide");
			Tooltip.SetDefault("Shoots a Water Bolt\nShoots mini-sharks with <right>");
		}

		public override void SetDefaults()
		{
			item.damage = 157;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
                        item.shoot = 27;
			item.shootSpeed = 11;
		}
		public override bool AltFunctionUse(Player player)
		{
			return true;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.damage = 135;
				item.useTime = 14;
				item.useAnimation = 14;
			        item.useStyle = 5;
                                item.shoot = 408;
                                item.shootSpeed = 14;
			}
			else
			{
				item.damage = 157;
				item.useTime = 17;
				item.useAnimation = 17;
			        item.useStyle = 1;
                                item.shoot = 27;
                                item.shootSpeed = 11;
			}
			return base.CanUseItem(player);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpiritScale", 777);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

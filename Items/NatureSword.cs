using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class NatureSword : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Nature's Wrath");
			Tooltip.SetDefault("The meme!\nSwings like a shortsword with <right>");
		}

		public override void SetDefaults()
		{
			item.damage = 104;
			item.melee = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType<NatureSwordP>();
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
				item.damage = 114;
				item.useTime = 14;
				item.useAnimation = 14;
			        item.useStyle = 3;
			}
			else
			{
				item.damage = 104;
				item.useTime = 17;
				item.useAnimation = 17;
			        item.useStyle = 1;
			}
			return base.CanUseItem(player);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SpiritScale", 777);
			recipe.AddIngredient(ItemID.SpectreBar, 5);
			recipe.AddIngredient(ItemID.Ectoplasm, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

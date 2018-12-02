using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class FrostStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Frost Staff");
			Tooltip.SetDefault("Shoots a frost wave");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 11;
			item.magic = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 1;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.mana = 6;
                        item.shoot = mod.ProjectileType<FrostStaffP>();
			item.shootSpeed = 12f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ItemID.IceBlock, 10);
                        recipe.AddIngredient(ItemID.SnowBlock, 25);
                        recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

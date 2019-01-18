using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class FireStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Flame Staff");
			Tooltip.SetDefault("Shoots a fire wave");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.magic = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.mana = 8;
                        item.shoot = mod.ProjectileType<FireStaffP>();
			item.shootSpeed = 12f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ItemID.HellstoneBar, 8);
                        recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class MagicStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Soul Staff");
			Tooltip.SetDefault("Shoots a Soul Flame!");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 8;
			item.magic = true;
			item.width = 40;
			item.height = 32;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 600;
			item.rare = 1;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.mana = 3;
                        item.shoot = mod.ProjectileType<SoulFlameP>();
			item.shootSpeed = 7f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(ItemID.Wood, 8);
			                        recipe.AddIngredient(null, "SoulFire", 10);
                        recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

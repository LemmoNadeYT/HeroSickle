
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class NeedleBurst : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Needle Burst");
			Tooltip.SetDefault("Shoots deadly needles!");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.magic = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
      item.mana = 3;
                        item.shoot = mod.ProjectileType<NeedleP>();
			item.shootSpeed = 12f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
                        recipe.AddIngredient(null, "CactiBar", 15);
                        recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class ObsidianDemon : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Obsidian Demon");
			Tooltip.SetDefault("Not obsidian, it's made out of Hellstone!");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
                        item.thrown = true;
			item.width = 999;
			item.height = 999;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = Item.buyPrice(gold: 1);
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 14;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.shoot = mod.ProjectileType<ObsidianDemonP>();
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

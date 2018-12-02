using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class CactiShield : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Cacti Shield");
			Tooltip.SetDefault("The King and the Queen's power combined...\n+3% magic damage");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 5;
			item.expert = true;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.magicDamage += 0.03f;
                }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CactiMagic");
			recipe.AddIngredient(null, "WoodShield");
                        recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
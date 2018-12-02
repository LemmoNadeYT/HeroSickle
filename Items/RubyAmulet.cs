using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class RubyAmulet : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Ruby Amulet");
			Tooltip.SetDefault("Only worn by the royal...\n+6% melee damage\n+1 life regen\n+10 max life");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.defense = 6;
			item.expert = true;
                        item.lifeRegen = 1;
                }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage += 0.06f;
                        player.statLifeMax2 += 10;
                }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CactiShield");
			recipe.AddIngredient(null, "KnightCharm");
			recipe.AddIngredient(ItemID.Ruby, 2);
			recipe.AddIngredient(null, "EmptyAmulet");
                        recipe.AddTile(TileID.WorkBenches);

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
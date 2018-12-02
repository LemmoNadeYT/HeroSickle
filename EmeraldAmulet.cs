using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class EmeraldAmulet : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Emerald Amulet");
			Tooltip.SetDefault("Only worn by the royal...\n+6% ranged damage\n+0.5 life and mana regen\n+5 max life and mana");
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
			player.rangedDamage += 0.06f;
                        player.statLifeMax2 += 5;
                        player.statManaMax2 += 5;
                }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CactiShield");
			recipe.AddIngredient(null, "KnightCharm");
			recipe.AddIngredient(ItemID.Emerald, 2);
			recipe.AddIngredient(null, "EmptyAmulet");
                        recipe.AddTile(TileID.WorkBenches);

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
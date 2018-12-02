using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SapphireAmulet : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Sapphire Amulet");
			Tooltip.SetDefault("Only worn by the royal...\n+6% magic damage\n+1 mana regen\n+10 max mana");
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
			player.magicDamage += 0.06f;
                        player.statManaMax2 += 10;
                }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CactiShield");
			recipe.AddIngredient(null, "KnightCharm");
			recipe.AddIngredient(ItemID.Sapphire, 2);
			recipe.AddIngredient(null, "EmptyAmulet");
                        recipe.AddTile(TileID.WorkBenches);

			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
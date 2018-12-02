using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class DarkChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dark Breastplate");
			Tooltip.SetDefault("Don't use this at night...\n+3% melee damage and speed");
		}
		public override void UpdateEquip(Player player)
		{
                        player.meleeDamage += 0.03f;
                        player.meleeSpeed += 0.03f;
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 10000;
			item.rare = 1;
			item.defense = 3;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkLeadBar", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
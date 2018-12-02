using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class DarkLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Dark Leggings");
	
			Tooltip.SetDefault("Don't use this at night...\n+2% melee speed");
		}

		public override void UpdateEquip(Player player)
		{
                        player.meleeSpeed += 0.02f;
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 10000;
			item.rare = 1;
			item.defense = 2;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkLeadBar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
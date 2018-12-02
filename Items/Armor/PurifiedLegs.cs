using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class PurifiedLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Purified Leggings");
	
			Tooltip.SetDefault("+10% move speed");
		}

		public override void UpdateEquip(Player player)
		{
                        player.moveSpeed += 0.10f;
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 10000;
			item.rare = 8;
			item.defense = 11;

}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PurifiedBar", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
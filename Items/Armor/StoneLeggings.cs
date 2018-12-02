using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class StoneLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Stone Leggings");
	
			Tooltip.SetDefault("Not very effective...\n-3% move speed");
		}

		public override void UpdateEquip(Player player)
		{
                        player.moveSpeed -= 0.03f;
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = -1;
			item.defense = 2;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
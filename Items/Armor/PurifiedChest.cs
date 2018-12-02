using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class PurifiedChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Purified Breastplate");
			Tooltip.SetDefault("+15% magic damage");
		}
		public override void UpdateEquip(Player player)
		{
                        player.magicDamage += 0.15f;
		}
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 10000;
			item.rare = 8;
			item.defense = 14;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PurifiedBar", 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
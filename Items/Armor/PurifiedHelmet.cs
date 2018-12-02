using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PurifiedHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Purified Helmet");
	
			Tooltip.SetDefault("+10% magic damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 18;
			item.value = 10000;
			item.rare = 8;
			item.defense = 9;
		}
		public override void UpdateEquip(Player player)
		{
                        player.magicDamage += 0.10f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("PurifiedChest") && legs.type == mod.ItemType("PurifiedLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+7% magic damage\nPhilosophers Stone effect!";
                        player.magicDamage += 0.7f;
                        player.pStone = true; 

}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PurifiedBar", 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
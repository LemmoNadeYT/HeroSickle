using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class DarkHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Dark Helmet");
	
			Tooltip.SetDefault("Don't use this at night...\n+2% melee damage and speed");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 10000;
			item.rare = 1;
			item.defense = 2;
		}
		public override void UpdateEquip(Player player)
		{
                        player.meleeDamage += 0.02f;
                        player.meleeSpeed += 0.02f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("DarkChest") && legs.type == mod.ItemType("DarkLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+4% melee damage";
                        player.meleeDamage += 0.04f;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "DarkLeadBar", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
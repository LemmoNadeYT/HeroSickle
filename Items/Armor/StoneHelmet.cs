using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class StoneHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Stone Helmet");
	
			Tooltip.SetDefault("This doesn't even look like stone!\n-3% move speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = -1;
			item.defense = 2;
		}
		public override void UpdateEquip(Player player)
		{
                        player.moveSpeed -= 0.03f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("StoneBreastplate") && legs.type == mod.ItemType("StoneLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "3% melee speed";
                        player.meleeSpeed += 0.03f;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
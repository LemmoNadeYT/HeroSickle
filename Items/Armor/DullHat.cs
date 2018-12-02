using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class DullHat : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Magic Hat");
	
			Tooltip.SetDefault("Shoots bunnies if used\n+3% magic damage if worn");
		}

		public override void UpdateEquip(Player player)
		{
                        player.magicDamage += 0.03f;
		}
		public override void SetDefaults()
		{
			item.damage = 6;
			item.magic = true;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 3;
			item.noMelee = true;
			item.knockBack = 3;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 281;
			item.shootSpeed = 12f;
                        item.mana = 6;
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 0;
			item.defense = 2;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
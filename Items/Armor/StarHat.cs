using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class StarHat : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Starry Hat");
	
			Tooltip.SetDefault("Summons stars if used\n+5% magic damage if worn");
		}

		public override void UpdateEquip(Player player)
		{
                        player.magicDamage += 0.05f;
		}
		public override void SetDefaults()
		{
			item.damage = 13;
			item.magic = true;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 3;
			item.noMelee = true;
			item.knockBack = 3;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 12;
			item.shootSpeed = 15f;
                        item.mana = 4;
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 1;
			item.defense = 3;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 7);
			recipe.AddIngredient(null, "DullHat");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
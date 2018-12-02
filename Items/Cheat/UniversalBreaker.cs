using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items.Cheat
{
    [AutoloadEquip(EquipType.Wings)]
    public class UniversalBreaker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reality Breaker");
            Tooltip.SetDefault("Breaks reality in two...\n+777 regen\n77% melee speed\n777x melee damage\n777x magic damage\n777x ranged damage\n77777 armor penetration!\n+7777 max health\n+77 max mana\nPhilosophers Stone effect\nAllows INFINITE flight\nUse with 'Wing Slot' mod!\n[c/f1a500:-Cheat Item-]");
        }
        public override void SetDefaults()
        {

            item.value = Item.sellPrice(77, 77, 77, 77);
	    item.rare = -11;
            item.accessory = true;
	    item.defense = 777;
            item.lifeRegen = 777;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "UniversalCore");
            recipe.AddIngredient(null, "ArmorBreaker");
            recipe.AddIngredient(null, "CheatMedal");
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
	    player.meleeDamage += 777f; //ATTACK
            player.meleeSpeed += 0.77f;
	    player.magicDamage += 777f;
	    player.rangedDamage += 777f;
            player.armorPenetration += 7777;

            player.statLifeMax2 += 7777;
            player.statManaMax2 += 77;  //DEFENSIVE


            player.pStone = true;       //OTHER
            player.waterWalk = true;
            player.fireWalk = true;
            player.accRunSpeed = 77f;
            player.moveSpeed += 27f;

	    player.wingTimeMax = 77777;  //WINGS
}
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 7f;
			ascentWhenRising = 3f;
			maxCanAscendMultiplier = 7f;
			maxAscentMultiplier = 7f;
			constantAscend = 0.7f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 27f;
			acceleration *= 17f;
		}
        }
    }
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class UniversalCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cosmic Core");
            Tooltip.SetDefault("A fragment of reality...\n+3 regen\n18% melee damage and melee speed\n8% magic damage\n8% ranged damage\n+10 armor penetration\n+110 max health\nAbilities from Solar Boots\nPhilosophers Stone effect\nAllows flight and slow fall better then Solar Wings\nUse with 'Wing Slot' mod!");
        }
        public override void SetDefaults()
        {

            item.value = Item.sellPrice(1, 25, 0, 0);
            item.rare = 11;
            item.accessory = true;
	    item.defense = 18;
            item.lifeRegen = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "RubyAmulet");
            recipe.AddIngredient(null, "EmeraldAmulet");
            recipe.AddIngredient(null, "SapphireAmulet");
            recipe.AddIngredient(null, "SolarBoots");
            recipe.AddIngredient(null, "OmegaHeart");
            recipe.AddIngredient(null, "LunarCrusher");
            recipe.AddIngredient(ItemID.SharkToothNecklace);
            recipe.AddIngredient(ItemID.FireGauntlet);
            recipe.AddIngredient(ItemID.PhilosophersStone);
            recipe.AddIngredient(ItemID.WingsStardust);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
	    player.meleeDamage += 0.18f; //ATTACK
            player.meleeSpeed += 0.18f;
	    player.magicDamage += 0.08f;
	    player.rangedDamage += 0.08f;
            player.armorPenetration += 10;

            player.statLifeMax2 += 130;  //DEFENSIVE
	    item.defense = 12;


            player.pStone = true;       //OTHER
            player.lavaMax += 500;
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaRose = true;
            player.rocketBoots = 10;
            player.accRunSpeed = 20f;
            player.moveSpeed += 3f;
            player.iceSkate = true;

	    player.wingTimeMax = 200;  //WINGS
}
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 2f;
			ascentWhenRising = 1f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.1f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 9f;
			acceleration *= 4f;
		}
        }
    }
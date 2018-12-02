using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
    public class SolarBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solaric Striders");
            Tooltip.SetDefault("Abilities from the Magmatic and Frostspark boots, but upgraded!\n7% Increased melee damage!");
        }
        public override void SetDefaults()
        {

            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 8;
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "InfernoBoots");
            recipe.AddIngredient(ItemID.FragmentSolar, 5);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lavaMax += 500;
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaRose = true;
            player.rocketBoots = 10;
            player.accRunSpeed = 20f;
            player.moveSpeed += 3f;
            player.iceSkate = true;
	    player.meleeDamage += 0.07f;
        }
    }
}
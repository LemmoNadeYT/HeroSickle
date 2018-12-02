using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
    public class InfernoBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Inferno Boots");
            Tooltip.SetDefault("Abilities from Magmatic and Frostspark boots!\nDoes not Inflict 'On Fire'");
        }
        public override void SetDefaults()
        {

            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MagmaBoots");
            recipe.AddIngredient(ItemID.FrostsparkBoots);
            recipe.AddIngredient(ItemID.LivingFireBlock, 25);
            recipe.AddIngredient(ItemID.MagmaStone);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.lavaMax += 480;
            player.waterWalk = true;
            player.fireWalk = true;
            player.lavaRose = true;
            player.rocketBoots = 3;
            player.accRunSpeed = 4.75f;
            player.moveSpeed += 0.7f;
            player.iceSkate = true;
        }
    }
}
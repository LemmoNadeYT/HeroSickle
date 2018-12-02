using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
    public class MagmaBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magmatic Boots");
            Tooltip.SetDefault("Allows the ability to walk on liquids!\nImmunity to fire blocks!\n8 seconds of immunity to lava!\nHurt less from lava!");
        }
        public override void SetDefaults()
        {

            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 3;
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LavaWaders);
            recipe.AddIngredient(ItemID.ObsidianRose);
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
        }
    }
}
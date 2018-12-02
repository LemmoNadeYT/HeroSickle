using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
    public class ArmorBreaker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bone Dust");
            Tooltip.SetDefault("Enemies have no defence!\nBOSSES INCLUDED!\nHow???!?!?");
        }
        public override void SetDefaults()
        {

            item.value = Item.sellPrice(1, 1, 6, 9);
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.armorPenetration += 99999999;
}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BoneKey);
                        recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
     
		}
        }
    }
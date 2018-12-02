using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class LemmoWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("lemmoNade's Wings");
            Tooltip.SetDefault("whaa..?\n[c/04c3f9:-Dev Item-]");
        }
        public override void SetDefaults()
        {

            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 9;
            item.accessory = true;
        }
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.6f;
			ascentWhenRising = 0.4f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 6f;
			constantAscend = 0.1f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 6f;
			acceleration *= 3f;
		}
        }
    }
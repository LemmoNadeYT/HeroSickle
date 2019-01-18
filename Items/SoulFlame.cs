using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SoulFlame : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("Soul Flame");
			Tooltip.SetDefault("What keeps people alive\nUseful for magic");
			ItemID.Sets.ItemNoGravity[item.type] = true;
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(3, 2));
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 22;
			item.value = 50;
			item.rare = 1;
			item.maxStack = 99;
                }
	}
}

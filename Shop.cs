using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;

namespace HeroSickle
{
	public class Shop : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.Dryad)
			{
                                shop.item[nextSlot].SetDefaults(ItemID.LivingLoom);
                                shop.item[nextSlot].value = 20000;
				nextSlot++;

                                shop.item[nextSlot].SetDefaults(ItemID.LivingWoodWand);
                                shop.item[nextSlot].value = 500;
				nextSlot++;

                                shop.item[nextSlot].SetDefaults(ItemID.LeafWand);
                                shop.item[nextSlot].value = 500;
				nextSlot++;
}
			if (type == NPCID.Clothier)
			{
                                shop.item[nextSlot].SetDefaults(ItemID.Silk);
                                shop.item[nextSlot].value = 200;
				nextSlot++;
			}
}
}
}
using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	public class GoldenBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gilded Creeper's Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 1;
			item.expert = true;
			bossBagNPC = mod.NPCType("GoldenCreeper");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			if (Main.rand.Next(3) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("GoldHeart"));
			}
			player.QuickSpawnItem(mod.ItemType("PurifiedBar"), Main.rand.Next(11, 21));
			player.QuickSpawnItem(mod.ItemType("SteelHorn"));
		}
	}
}
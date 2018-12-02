using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	public class DesertBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Reaper's Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 2;
			item.expert = true;
			bossBagNPC = mod.NPCType("DesertReaper");
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
				player.QuickSpawnItem(mod.ItemType("BlankHeart"));
			}
			if (Main.rand.Next(25) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("CheatMedal"));
			}
			player.QuickSpawnItem(mod.ItemType("CorruptMagic"));
			player.QuickSpawnItem(mod.ItemType("MultiCactus"), Main.rand.Next(24, 36));
		}
	}
}
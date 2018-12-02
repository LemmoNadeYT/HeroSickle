using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	public class KnightBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zombie Knight's Treasure Bag");
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
			bossBagNPC = mod.NPCType("KnightZombie");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			if (Main.rand.Next(3) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("LeadHeart"));
			}
			player.QuickSpawnItem(mod.ItemType("KnightCharm"));
			player.QuickSpawnItem(mod.ItemType("DarkLeadBar"), Main.rand.Next(15, 20));
			player.QuickSpawnItem(mod.ItemType("HugeSword"));
			player.QuickSpawnItem(mod.ItemType("HugeStabber"));
		}
	}
}
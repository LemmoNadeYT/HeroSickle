using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.NPCs
{
	public class UndeadSummon : ModItem
	{
		public override void SetStaticDefaults()
		{       DisplayName.SetDefault("Undead Sword");

			Tooltip.SetDefault("Summons the Zombie Knight");
		}

		public override void SetDefaults()
		{
			item.width = 999;
			item.height = 999;
			item.maxStack = 20;
			item.rare = 1;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = 4;
			item.UseSound = SoundID.Item4;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return NPC.downedBoss1 && !NPC.AnyNPCs(mod.NPCType("KnightZombie"));
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("KnightZombie"));
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddIngredient(null, "DarkLeadBar", 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
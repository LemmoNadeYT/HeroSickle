using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class LemmoHair : ModItem
	{
		public override void SetStaticDefaults()
		{
                        DisplayName.SetDefault("lemmoNade's Hair");
	
			Tooltip.SetDefault("So fancy!\n[c/04c3f9:-Dev Item-]");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 9;
		}
	}
}
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace HeroSickle.Items
{
    public class AquaTrident : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aqua Trident");
	    Tooltip.SetDefault("");

        }

        public override void SetDefaults()
        {
            item.damage = 17;
            item.useStyle = 5;
            item.useAnimation = 12;
            item.useTime = 24;
            item.shootSpeed = 5; // The shoot speed for the spear projectile.
            item.knockBack = 4f;
            item.width = 999;
            item.height = 999;
            item.scale = 1f; // The scale of the item.
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.value = 1000;
            item.melee = true;
            item.autoReuse = true; // Will auto reuse the item.

            item.noMelee = true;
            item.noUseGraphic = true;
            item.shoot = mod.ProjectileType<AquaTridentP>();
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 1; // Only one spear can be on screen at a time. 
        }
    }
}
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class FrostStaffP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 20;
			projectile.height = 20;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

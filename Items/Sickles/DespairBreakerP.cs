using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class DespairBreakerP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 30;
			projectile.height = 30;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.penetrate = 4;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.scale = 1f;
		}
	}
}

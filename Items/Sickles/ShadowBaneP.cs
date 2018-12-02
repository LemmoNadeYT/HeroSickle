using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class ShadowBaneP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 28;
			projectile.height = 24;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.penetrate = 5;
			projectile.melee = true;
			projectile.tileCollide = false;
			projectile.scale = 1f;
		}
	}
}

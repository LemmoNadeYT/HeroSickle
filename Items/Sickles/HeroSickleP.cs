using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class HeroSickleP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 50;
			projectile.height = 48;
			projectile.aiStyle = 18;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.scale = 1f;
		}
	}
}

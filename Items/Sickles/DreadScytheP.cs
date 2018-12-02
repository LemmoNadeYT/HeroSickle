using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class DreadScytheP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 30;
			projectile.height = 30;
			projectile.aiStyle = 18;
			projectile.friendly = true;
			projectile.penetrate = 5;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.scale = 1f;
		}
	}
}

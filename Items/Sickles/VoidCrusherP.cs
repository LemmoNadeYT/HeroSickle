using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Sickles
{
	public class VoidCrusherP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 26;
			projectile.height = 26;
			projectile.aiStyle = 14;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.scale = 1f;
		}
	}
}

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class NebulaBoomBoxP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 22;
			projectile.height = 24;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

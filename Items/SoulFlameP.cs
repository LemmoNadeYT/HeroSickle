using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SoulFlameP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 16;
			projectile.height = 22;
			projectile.aiStyle = 18;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.scale = 1f;
		}
	}
}

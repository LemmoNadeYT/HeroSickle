using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class PalShuriP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 28;
			projectile.height = 28;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

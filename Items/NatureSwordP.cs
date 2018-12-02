using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class NatureSwordP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 18;
			projectile.height = 24;
                        aiType = 207;
                        projectile.CloneDefaults(207);
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

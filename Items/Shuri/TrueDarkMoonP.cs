using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class TrueDarkMoonP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 26;
			projectile.height = 26;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = 4;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

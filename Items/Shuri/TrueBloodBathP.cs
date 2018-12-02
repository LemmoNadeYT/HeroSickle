using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items.Shuri
{
	public class TrueBloodBathP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 26;
			projectile.height = 26;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

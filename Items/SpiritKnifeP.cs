using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class SpiritKnifeP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 14;
			projectile.height = 34;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class ShroomDaggerP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 10;
			projectile.height = 24;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

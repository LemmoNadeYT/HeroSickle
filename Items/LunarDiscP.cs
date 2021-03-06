﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class LunarDiscP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.penetrate = 4;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

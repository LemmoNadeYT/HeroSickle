﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HeroSickle.Items
{
	public class HeroStaffP : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 22;
			projectile.height = 22;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.melee = true;
			projectile.scale = 1f;
		}
	}
}

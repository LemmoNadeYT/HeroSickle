using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ModLoader;

namespace HeroSickle.DeathDamagePlayer
{
	public class DeathDamagePlayer : ModPlayer
	{
		public static DeathDamagePlayer ModPlayer(Player player)
		{
			return player.GetModPlayer<DeathDamagePlayer>();
		}

		public float deathDamage = 1f;

		public override void ResetEffects()
		{
			ResetVariables();
		}

		public override void UpdateDead()
		{
			ResetVariables();
		}

		private void ResetVariables()
		{
			deathDamage = 1f;
		}
	}
}
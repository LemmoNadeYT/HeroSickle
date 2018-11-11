using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ModLoader;
using HeroSickle.Items;
using HeroSickle.Items.Sickles;

namespace HeroSickle
{
    public abstract class DeathItem : ModItem
    {
        public override void SetDefaults()
        {
            item.melee = false;
            item.ranged = false;
            item.magic = false;
            item.thrown = false;
            item.summon = false;
            item.crit = 4;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            var tt = tooltips.FirstOrDefault(x => x.Name == "Damage" && x.mod == "Terraria");
            if (tt != null)
            {
                string[] split = tt.text.Split(' ');
                tt.text = split.First() + " death " + split.Last();
            }
        }

        public override void GetWeaponDamage(Player player, ref int damage)
        {
            HeroSicklePlayer modPlayer = player.GetModPlayer<HeroSicklePlayer>(mod);
            damage = (int)(damage * modPlayer.deathDamage);
            modPlayer.deathHold = true;
      }
    }
}
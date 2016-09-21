using System;
using Activator.Base;
using LeagueSharp.Common;

namespace Activator.Summoners
{
    class teleport : CoreSum
    {
        internal override string Name => "summonerteleport";
        internal override string DisplayName => "Teleport";
        internal override string[] ExtraNames => new[] { "" };
        internal override float Range => float.MaxValue;
        internal override int Duration => 3500;

        static bool IsLethal(Champion hero)
        {
            return hero.Player.Health/hero.Player.MaxHealth * 100 <= 35 && hero.IncomeDamage > 0 ||
                   hero.HitTypes.Contains(HitType.Ultimate) && hero.IncomeDamage > 0;
        }

        public override void OnDraw(EventArgs args)
        {
            if (IsReady() && Menu.Item("teledraw").GetValue<bool>())
            {
                foreach (var hero in Activator.Allies())
                {
                    if (hero.Player.IsValid && !hero.Player.IsZombie && !hero.Player.IsDead)
                    {
                        if (IsLethal(hero) && !hero.Player.IsMe)
                        {
                            Utility.DrawCircle(hero.Player.Position, 850f, System.Drawing.Color.Crimson, 3, 30, true);
                        }
                    }
                }
            }          
        }
    }
}

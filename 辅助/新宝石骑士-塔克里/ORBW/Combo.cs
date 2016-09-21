namespace SkyLv_Taric
{
    using System;

    using LeagueSharp;
    using LeagueSharp.Common;

    internal class Combo
    {
        #region #GET
        private static Obj_AI_Hero Player
        {
            get
            {
                return SkyLv_Taric.Player;
            }
        }

        private static Spell Q
        {
            get
            {
                return SkyLv_Taric.Q;
            }
        }

        private static Spell W
        {
            get
            {
                return SkyLv_Taric.W;
            }
        }

        private static Spell E
        {
            get
            {
                return SkyLv_Taric.E;
            }
        }

        private static Spell R
        {
            get
            {
                return SkyLv_Taric.R;
            }
        }
        #endregion


        static Combo()
        {
            //Menu
            SkyLv_Taric.Menu.SubMenu("Combo").AddItem(new MenuItem("Taric.UseQCombo", "Use Q In Combo").SetValue(true));
            SkyLv_Taric.Menu.SubMenu("Combo").AddItem(new MenuItem("Taric.UseWCombo", "Use W In Combo").SetValue(true));
            SkyLv_Taric.Menu.SubMenu("Combo").AddItem(new MenuItem("Taric.UseECombo", "Use E In Combo").SetValue(true));
            SkyLv_Taric.Menu.SubMenu("Combo").AddItem(new MenuItem("Taric.UseTaricAAPassiveCombo", "Use All Taric AA Passive In Combo").SetValue(true));
            SkyLv_Taric.Menu.SubMenu("Combo").AddItem(new MenuItem("Taric.UsePacketCastCombo", "Use PacketCast In Combo").SetValue(false));

            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            ComboLogic();
        }

        public static void ComboLogic()
        {
            var PacketCast = SkyLv_Taric.Menu.Item("Taric.UsePacketCastCombo").GetValue<bool>();
            var useQ = SkyLv_Taric.Menu.Item("Taric.UseQCombo").GetValue<bool>();
            var useW = SkyLv_Taric.Menu.Item("Taric.UseWCombo").GetValue<bool>();
            var useE = SkyLv_Taric.Menu.Item("Taric.UseECombo").GetValue<bool>();

            if (SkyLv_Taric.Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
            {
                var target = TargetSelector.GetTarget(E.Range, TargetSelector.DamageType.Physical);

                if (target.IsValidTarget())
                {
                    if (useE && E.IsReady() && (!CustomLib.HavePassiveAA() || !SkyLv_Taric.Menu.Item("Taric.UseTaricAAPassiveCombo").GetValue<bool>()))
                    {
                        if (Player.Distance(target) < E.Range)
                        {
                            E.CastIfHitchanceEquals(target, HitChance.VeryHigh, PacketCast);
                            return;
                        }
                    }

                    if (useW && W.IsReady() && (!CustomLib.HavePassiveAA() || !SkyLv_Taric.Menu.Item("Taric.UseTaricAAPassiveCombo").GetValue<bool>()) && (!E.IsReady() || !useE))
                    {
                        W.Cast(Player, PacketCast);
                        return;
                    }

                    if (useQ && Q.IsReady() && (!CustomLib.HavePassiveAA() || !SkyLv_Taric.Menu.Item("Taric.UseTaricAAPassiveCombo").GetValue<bool>()) && (!E.IsReady() || !useE) && (Player.HealthPercent < 100 || (!W.IsReady() || !useW)))
                    {
                        Q.Cast(Player, PacketCast);
                        return;
                    }
                }
            }
        }
    }
}

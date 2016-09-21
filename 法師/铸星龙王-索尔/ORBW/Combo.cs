namespace SkyLv_AurelionSol
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
                return SkyLv_AurelionSol.Player;
            }
        }

        private static Spell Q
        {
            get
            {
                return SkyLv_AurelionSol.Q;
            }
        }

        private static Spell W1
        {
            get
            {
                return SkyLv_AurelionSol.W1;
            }
        }

        private static Spell W2
        {
            get
            {
                return SkyLv_AurelionSol.W2;
            }
        }
        #endregion


        static Combo()
        {
            //Menu
            SkyLv_AurelionSol.Menu.SubMenu("Combo").AddItem(new MenuItem("AurelionSol.UseQCombo", "Use Q In Combo").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").AddItem(new MenuItem("AurelionSol.UseWCombo", "Use W In Combo").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").AddItem(new MenuItem("AurelionSol.AutoManageW", "Auto Manage W").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").AddItem(new MenuItem("AurelionSol.AutoR", "Auto R If Minimum Enemy Hit").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").AddItem(new MenuItem("AurelionSol.MinimumEnemyHitAutoR", "Minimum Enemy Hit To Use R").SetValue(new Slider(3, 1, 5)));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").AddItem(new MenuItem("AurelionSol.UsePacketCastCombo", "Use PacketCast In Combo").SetValue(false));

            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            ComboLogic();
        }

        public static void ComboLogic()
        {
            var PacketCast = SkyLv_AurelionSol.Menu.Item("AurelionSol.UsePacketCastCombo").GetValue<bool>();
            var useQ = SkyLv_AurelionSol.Menu.Item("AurelionSol.UseQCombo").GetValue<bool>();
            var useW = SkyLv_AurelionSol.Menu.Item("AurelionSol.UseWCombo").GetValue<bool>();



            if (SkyLv_AurelionSol.Orbwalker.ActiveMode == Orbwalking.OrbwalkingMode.Combo)
            {
                var target = TargetSelector.GetTarget(W2.Range + 50, TargetSelector.DamageType.Magical);

                if (target != null)
                {
                    if (useQ && Q.IsReady())
                    {
                        var prediction = Q.GetPrediction(target);
                        if (prediction.Hitchance >= HitChance.High)
                        {
                            Q.Cast(prediction.CastPosition, PacketCast);
                        }
                    }

                    if (useW)
                    {
                        if (target.Distance(Player) <= W1.Range + 50 && MathsLib.isWInLongRangeMode())
                        {
                            W2.Cast(PacketCast);
                        }

                        if (target.Distance(Player) > W1.Range + 50 && target.Distance(Player) < W2.Range + 50 && !MathsLib.isWInLongRangeMode())
                        {
                            W1.Cast(PacketCast);
                        }

                        else if (MathsLib.enemyChampionInRange(600 + 300) == 0 && MathsLib.isWInLongRangeMode())
                        {
                            W2.Cast(PacketCast);
                        }
                    }
                }
                
            }
        }
    }
}

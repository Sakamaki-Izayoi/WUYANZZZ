namespace SkyLv_AurelionSol
{
    using System;
    using System.Linq;

    using LeagueSharp;
    using LeagueSharp.Common;


    internal class KillSteal
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

        private static Spell R
        {
            get
            {
                return SkyLv_AurelionSol.R;
            }
        }
        #endregion




        static KillSteal()
        {
            //Menu
            SkyLv_AurelionSol.Menu.SubMenu("Combo").AddSubMenu(new Menu("KS Mode", "KS Mode"));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("KS Mode").AddItem(new MenuItem("AurelionSol.UseIgniteKS", "KS With Ignite").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("KS Mode").AddItem(new MenuItem("AurelionSol.UseQKS", "KS With Q").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("KS Mode").AddItem(new MenuItem("AurelionSol.UseWKS", "KS With W").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("KS Mode").AddItem(new MenuItem("AurelionSol.UseRKS", "KS With R").SetValue(true));
            SkyLv_AurelionSol.Menu.SubMenu("Combo").SubMenu("KS Mode").AddItem(new MenuItem("AurelionSol.PacketCastKS", "PacketCast KS").SetValue(false));

            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            KS();
        }

        #region KillSteal
        public static void KS()
        {
            var PacketCast = SkyLv_AurelionSol.Menu.Item("AurelionSol.PacketCastKS").GetValue<bool>();
            var useIgniteKS = SkyLv_AurelionSol.Menu.Item("AurelionSol.UseIgniteKS").GetValue<bool>();
            var useQKS = SkyLv_AurelionSol.Menu.Item("AurelionSol.UseQKS").GetValue<bool>();
            var useWKS = SkyLv_AurelionSol.Menu.Item("AurelionSol.UseWKS").GetValue<bool>();
            var useRKS = SkyLv_AurelionSol.Menu.Item("AurelionSol.UseRKS").GetValue<bool>();

            foreach (var target in ObjectManager.Get<Obj_AI_Hero>().Where(target => !target.IsMe && target.Team != ObjectManager.Player.Team))
            {

                if (!target.HasBuff("SionPassiveZombie") && !target.HasBuff("Udying Rage") && !target.HasBuff("JudicatorIntervention"))
                {
                    if (useQKS && Q.IsReady() && target.Health < MathsLib.QDamage(target) && !target.IsDead)
                    {
                        var prediction = Q.GetPrediction(target);
                        if (prediction.Hitchance >= HitChance.High)
                        {
                            Q.Cast(prediction.CastPosition, PacketCast);
                            return;
                        }
                        
                    }

                    if (useWKS && W1.IsReady() && target.Health < W1.GetDamage(target) && !target.IsDead)
                    {
                        if (Player.Distance(target) > W1.Range - 20 && Player.Distance(target) < W1.Range + 20 && MathsLib.isWInLongRangeMode())
                        {
                            W2.Cast(PacketCast);
                            return;
                        }

                        if (Player.Distance(target) > W2.Range - 20 && Player.Distance(target) < W2.Range + 20 && !MathsLib.isWInLongRangeMode())
                        {
                            W1.Cast(PacketCast);
                            return;
                        }
                        return;
                    }

                    if (useRKS && R.IsReady() && target.Health < MathsLib.RDamage(target) && !target.IsDead)
                    {
                        var prediction = R.GetPrediction(target);
                        if (prediction.Hitchance == HitChance.VeryHigh)
                        {
                            R.Cast(prediction.CastPosition, PacketCast);
                            return;
                        }
                        return;
                    }

                    if (useIgniteKS && SkyLv_AurelionSol.IgniteSlot.IsReady() && target.Health < Player.GetSummonerSpellDamage(target, Damage.SummonerSpell.Ignite) && Player.Distance(target) <= 600 && !target.IsDead && target.IsValidTarget())
                    {
                        Player.Spellbook.CastSpell(SkyLv_AurelionSol.IgniteSlot);
                        return;
                    }

                }

            }
        }
        #endregion
    }
}

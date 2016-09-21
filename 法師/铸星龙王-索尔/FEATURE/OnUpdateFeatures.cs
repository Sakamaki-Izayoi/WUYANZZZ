namespace SkyLv_AurelionSol
{
    using System;
    using System.Linq;

    using LeagueSharp;
    using LeagueSharp.Common;


    internal class OnUpdateFeatures
    {
        #region #GET
        private static Obj_AI_Hero Player
        {
            get
            {
                return SkyLv_AurelionSol.Player;
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

        static OnUpdateFeatures()
        {
            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            if (SkyLv_AurelionSol.Menu.Item("AurelionSol.AutoR").GetValue<bool>())
            {
                AutoR();
            }

            AutoWManager();
        }


        public static void AutoWManager()
        {
            var target = TargetSelector.GetTarget(W2.Range + 50, TargetSelector.DamageType.Magical);
            var PacketCast = SkyLv_AurelionSol.Menu.Item("AurelionSol.UsePacketCastCombo").GetValue<bool>();
            var AutoWManager = SkyLv_AurelionSol.Menu.Item("AurelionSol.AutoManageW").GetValue<bool>();
            if (AutoWManager)
            {
                if (MathsLib.enemyChampionInRange(600 + 300) == 0 && MathsLib.isWInLongRangeMode())
                {
                    W2.Cast(PacketCast);
                }
            }
        }

        public static void AutoR()
        {
            var target = TargetSelector.GetTarget(W2.Range + 50, TargetSelector.DamageType.Magical);
            var MinimumEnemyHitAutoR = SkyLv_AurelionSol.Menu.Item("AurelionSol.MinimumEnemyHitAutoR").GetValue<Slider>().Value;
            var PacketCast = SkyLv_AurelionSol.Menu.Item("AurelionSol.UsePacketCastCombo").GetValue<bool>();

            if (R.IsReady())
            {
                R.CastIfWillHit(target, MinimumEnemyHitAutoR, PacketCast);
            }


        }

    }
}

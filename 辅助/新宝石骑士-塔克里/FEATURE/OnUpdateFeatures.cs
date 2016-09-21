namespace SkyLv_Taric
{
    using System;

    using LeagueSharp;
    using LeagueSharp.Common;


    internal class OnUpdateFeatures
    {
        #region #GET
        private static Obj_AI_Hero Player
        {
            get
            {
                return SkyLv_Taric.Player;
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

        static OnUpdateFeatures()
        {
            //Menu
            SkyLv_Taric.Menu.SubMenu("Combo").AddSubMenu(new Menu("Auto Spell Usage", "Auto Spell Usage"));
            SkyLv_Taric.Menu.SubMenu("Combo").SubMenu("Auto Spell Usage").AddItem(new MenuItem("Taric.UseAutoR", "Use Auto R Safe Mode").SetValue(true));
            SkyLv_Taric.Menu.SubMenu("Combo").SubMenu("Auto Spell Usage").AddItem(new MenuItem("Taric.MinimumHpSafeAutoR", "Minimum Health Percent To Use Auto R Safe Mode").SetValue(new Slider(40, 0, 100)));

            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {

            if (SkyLv_Taric.Menu.Item("Taric.UseAutoR").GetValue<bool>())
            {
                AutoR();
            }
        }

        public static void AutoR()
        {
            var MinimumHpSafeAutoR = SkyLv_Taric.Menu.Item("Taric.MinimumHpSafeAutoR").GetValue<Slider>().Value;
            var PacketCast = SkyLv_Taric.Menu.Item("Taric.UsePacketCastCombo").GetValue<bool>();

            if (R.IsReady() && Player.Mana >= R.ManaCost && CustomLib.enemyChampionInPlayerRange(700) > 0 && Player.HealthPercent <= MinimumHpSafeAutoR)
            {
                R.Cast(Player, PacketCast);
            }
        }

    }
}

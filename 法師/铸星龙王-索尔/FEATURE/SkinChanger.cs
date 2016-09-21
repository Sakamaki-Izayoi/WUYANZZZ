﻿namespace SkyLv_AurelionSol
{
    using System;

    using LeagueSharp;
    using LeagueSharp.Common;

    internal class SkinChanger
    {

        #region #GET
        private static Obj_AI_Hero Player
        {
            get
            {
                return SkyLv_AurelionSol.Player;
            }
        }
        #endregion


        static SkinChanger()
        {
            //Menu
            SkyLv_AurelionSol.Menu.SubMenu("Misc").AddSubMenu(new Menu("Skin Changer", "Skin Changer"));
            SkyLv_AurelionSol.Menu.SubMenu("Misc").SubMenu("Skin Changer").AddItem(new MenuItem("AurelionSol.SkinChanger", "Use Skin Changer").SetValue(false));
            SkyLv_AurelionSol.Menu.SubMenu("Misc").SubMenu("Skin Changer").AddItem(new MenuItem("AurelionSol.SkinChangerName", "Skin choice").SetValue(new StringList(new[] { "Original", "Ashen Lord"})));

            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            Player.SetSkin(Player.CharData.BaseSkinName, SkyLv_AurelionSol.Menu.Item("AurelionSol.SkinChanger").GetValue<bool>() ? SkyLv_AurelionSol.Menu.Item("AurelionSol.SkinChangerName").GetValue<StringList>().SelectedIndex : Player.BaseSkinId);
        }

        
    }
}

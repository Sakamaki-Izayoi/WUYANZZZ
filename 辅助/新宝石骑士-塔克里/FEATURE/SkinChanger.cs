﻿namespace SkyLv_Taric
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
                return SkyLv_Taric.Player;
            }
        }
        #endregion


        static SkinChanger()
        {
            //Menu
            SkyLv_Taric.Menu.SubMenu("Misc").AddSubMenu(new Menu("Skin Changer", "Skin Changer"));
            SkyLv_Taric.Menu.SubMenu("Misc").SubMenu("Skin Changer").AddItem(new MenuItem("Taric.SkinChanger", "Use Skin Changer").SetValue(false));
            SkyLv_Taric.Menu.SubMenu("Misc").SubMenu("Skin Changer").AddItem(new MenuItem("Taric.SkinChangerName", "Skin choice").SetValue(new StringList(new[] 
            { "Original", "Emerald", "Armor Of The Fifth Age", "Bloodstone" })));

            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            if (SkyLv_Taric.Menu.Item("Taric.SkinChanger").GetValue<bool>())
            {
                Player.SetSkin(Player.CharData.BaseSkinName, SkyLv_Taric.Menu.Item("Taric.SkinChangerName").GetValue<StringList>().SelectedIndex);
            }
            else
                Player.SetSkin(Player.CharData.BaseSkinName, Player.BaseSkinId);
        }

        
    }
}

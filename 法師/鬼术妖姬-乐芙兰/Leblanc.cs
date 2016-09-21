#region
using System;
using System.Reflection;
using LeagueSharp;
using LeagueSharp.Common;

#endregion

namespace Leblanc
{
    internal class Leblanc
    {
        public static string ChampionName => "Leblanc";
        public static void Init()
        {
            CustomEvents.Game.OnGameLoad += Game_OnGameLoad;
        }

        private static void Game_OnGameLoad(EventArgs args)
        {
            if (ObjectManager.Player.CharData.BaseSkinName != ChampionName)
            {
                return;
            }

            Champion.PlayerSpells.Init();
            Modes.ModeConfig.Init();
            Common.CommonItems.Init();
            var fVersion = "<font color='#FFFFFF'>Version=" + Assembly.GetExecutingAssembly().GetName().Version + "</font>";
            Game.PrintChat("<font color=\"#1eff00\">濞涙▊婕㈠寲鏈€寮篤IP鑴氭湰缇わ細&#50;&#49;&#53;&#50;&#50;&#54;&#48;&#56;&#54;</font> - <font color=\"#00BFFF\">姝¤繋鍚勪綅鐨勫姞鍏ワ紒</font>");

            Console.Clear();
        }
    }
}
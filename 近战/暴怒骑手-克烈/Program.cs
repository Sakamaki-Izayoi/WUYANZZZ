using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using Hiki.Kled.Champions;

namespace Hiki.Kled
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += OnLoad;
        }

        private static void OnLoad(EventArgs args)
        {
            switch (ObjectManager.Player.ChampionName)
            {
                case "Kled":
                    new Champions.Kled();
                    break;
            }
        }
    }
}

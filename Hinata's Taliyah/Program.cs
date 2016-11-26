using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hinata_s_Taliyah.Champions;
using LeagueSharp;
using LeagueSharp.Common;

namespace Hinata_s_Taliyah
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += OnGameLoad;
        }

        private static void OnGameLoad(EventArgs args)
        {
            if (ObjectManager.Player.ChampionName == "Taliyah")
            {
                new Taliyah();
            }
            else
            {
                return;
            }
        }
    }
}

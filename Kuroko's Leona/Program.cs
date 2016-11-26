using System;
using Kuroko_s_Leona.Champions;
using LeagueSharp;
using LeagueSharp.Common;

namespace Kuroko_s_Leona
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomEvents.Game.OnGameLoad += OnGameLoad;
        }

        private static void OnGameLoad(EventArgs args)
        {
            if (ObjectManager.Player.ChampionName == "Leona")
            {
                new Leona();
            }
            else
            {
                Game.PrintChat(ObjectManager.Player.ChampionName + "NOT SUPPORTED");
                return;
            }
        }
    }
}

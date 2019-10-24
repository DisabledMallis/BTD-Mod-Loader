using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTDModLoader
{
    class SerealizeConfig
    {
        public class MainForm
        {
            public string Game { get; set; }
            public string GameDir { get; set; }
            public string LastMod { get; set; }
            public string LastPlugin { get; set; }
            
            public MainForm(string game, string gameDir, string lastMod, string lastPlugin)
            {
                Game = game;
                GameDir = gameDir;
                LastMod = lastMod;
                LastPlugin = lastPlugin;
            }
        }
    }
}
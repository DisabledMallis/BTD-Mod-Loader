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
            public string ExeName { get; set; }
            public string GameDir { get; set; }
            public string LastMod { get; set; }
            
            public MainForm(string game, string exeName, string gameDir, string lastMod)
            {
                Game = game;
                ExeName = exeName;
                GameDir = gameDir;
                LastMod = lastMod;
            }
        }
    }
}
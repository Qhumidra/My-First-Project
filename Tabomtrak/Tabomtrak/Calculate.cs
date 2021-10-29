using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabomtrak
{
    class Calculate
    {
        public string Blue { private get; set; }
        public string Red { private get; set; }
        public string Winner { get; private set; }
        public void Skor()
        {
            if (Convert.ToInt32(Blue) > Convert.ToInt32(Red))
                Winner = "Team A is Won.";
            else if (Convert.ToInt32(Red) > Convert.ToInt32(Blue))
                Winner = "Team B is Won.";
            else
                Winner = "Draw.";
        }
    }
}

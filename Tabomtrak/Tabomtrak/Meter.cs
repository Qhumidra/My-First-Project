using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabomtrak
{
    class Meter
    {
        int blue_point = 0, red_point = 0;
        public int Blue_Add { get { return blue_point += 1; } }
        public int Blue_Eject { get { return blue_point -= 1; } }
        public int Red_Add { get { return red_point += 1; } }
        public int Red_Eject { get { return red_point -= 1; } }
    }  
}

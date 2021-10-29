using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabomtrak
{
    class Number
    {
        Random random = new Random();
        int kontrol;
        int[] dizi = new int[6];
        public void SayiUret()
        {
            for (int i = 0; i < 6; i++)
            {
                kontrol = random.Next(0, 12);   
                dizi[i] = kontrol;
            }
        }
        public int Dizi { get { SayiUret(); return dizi[0]; } }
    }
}
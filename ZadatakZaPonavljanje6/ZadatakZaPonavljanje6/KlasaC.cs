using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class KlasaC
    {
        static public int Zbroj(int[] broj)
        {
            int Zbroj = broj.Sum();
            return Zbroj;
        }

        static public double Prosjek(int[] broj)
        {
            double Prosjek = broj.Average();
            return Prosjek;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] broj = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Unesite " + (i + 1) + ". broj: ");
                broj[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Zbroj unesenih brojeva je " + KlasaC.Zbroj(broj));
            Console.WriteLine("Prosjek unesenih brojeva je " + KlasaC.Prosjek(broj));
            Console.ReadKey();
        }
    }
}
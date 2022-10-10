using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaVjezbu1
{

    class KlasaC
    {
        int zbroj;
        double prosjek;

        public int Zbroj(int[] x)
        {
            for (int i = 0; i < 5; i++)
            {
                zbroj = zbroj + x[i];
            }
            return zbroj;
        }

        public double Prosjek(int[] x)
        {
            prosjek = zbroj/x.Length;
            return prosjek;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[5];

            int zbroj;
            double prosjek;

            KlasaC klasaC = new KlasaC();

            Console.WriteLine("Unesi 5 cijelih brojeva:");

            for (int i = 0; i < 5; i++)

            { x[i] = Convert.ToInt32(Console.ReadLine()); }

            zbroj = klasaC.Zbroj(x);
            prosjek = klasaC.Prosjek(x);

            Console.WriteLine("zbroj je: "+zbroj);
            Console.WriteLine("prosjek tih brojeva je: "+prosjek);




            Console.ReadKey();

        }
    }
}

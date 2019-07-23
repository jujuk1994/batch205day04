using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay04
{
    class Program
    {

        public static int hitung(int x)
        {
            return x + 2;
        }
        static void Main(string[] args)
        {
            int angka = 3;
            int angka2 = hitung(angka);
            bool status = true;

            Console.Write("Selamat Datang {0} {1} {2}\n ", angka, status, angka2);
            Console.Write("Selamat Datang "+ angka+" "+status);
            Console.ReadLine();
        }
    }
}

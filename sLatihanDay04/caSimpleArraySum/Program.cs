using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caSimpleArraySum
{
    class Program
    {
        static int simpleArraySum(string[] ar, int maxValue)
        {
            /*
             * Write your code here.
             */

            int hasil = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (maxValue == hasil)
                {
                    break;
                }
                else
                {
                    hasil += Convert.ToInt32(ar[i]);
                }
                
            }

            return hasil;

        }
        static void Main(string[] args)
        {
        
            int arCount = Convert.ToInt32(Console.ReadLine());
            int[] ary = new int[arCount];
            int result = 0;
            int ctr = 0;
            //Console.WriteLine(arCount);
            string bebas = Console.ReadLine();
            //Console.WriteLine(bebas);
            string[] ar = bebas.Split(' ');
            Console.WriteLine(simpleArraySum(ar, arCount));

            


            //foreach (var item in ar)
            //{
            //    //Console.WriteLine(item);
            //    ary[ctr] = Convert.ToInt32(item);
            //    ctr++;

            //}
            //foreach (var item in ary)
            //{
            //    result = result + item;
            //}

            // simpleArraySum(ar);

            //Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

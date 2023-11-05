using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpimTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] sayi2 = { 1, 2,3, 4, 5,6, 7, 8,9, 10 };

            for (int i = 0; i < sayi.Length; i++)
            {
             //   Console.WriteLine(sayi[i]);
                for (int j = 0; j < sayi2.Length; j++)
                {
                    Console.WriteLine("{0} ile {1} Çarpımı : {2}  ",sayi[i],sayi2[j], sayi2[j] * (sayi[i]));

                }
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorudeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 12, 23, 43, 45, 65, 71, 89 };

            int enkucuk = sayilar[0];
            int enBuyuk = sayilar[0];

            for (int i = 1; i < sayilar.Length; i++)
            {
                if (sayilar[i] < enkucuk)
                {
                    enkucuk = sayilar[i];
                }
                if (sayilar[i] > enBuyuk)
                {
                    enBuyuk = sayilar[i];
                }
                Console.WriteLine("En küçük sayı" + enkucuk);
                Console.WriteLine("En büyük sayı " + enBuyuk);
            }
        }
    }
}

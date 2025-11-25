using System.ComponentModel.Design;

namespace Udemy.Learn.D05._04IfOrnekKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              
             Kullanıcıdan 3 adet not değeri isteyelim. Bu not değerlerinin ortalamasını bulalım 
             ve ortalama değeri 
             
            90>= AA
            80>=BA
            70>=BB
            60>=CB
            60<FF

             */
            Console.Write("1.Not degerinizi giriniz: ");
            string strNot1 = Console.ReadLine();

            Console.Write("2.Not degerinizi giriniz: ");
            string strNot2 = Console.ReadLine();

            Console.Write("3. Not degerinizi giriniz:");
            string strNot3 = Console.ReadLine();

            double not1 = Convert.ToDouble(strNot1);
            double not2 = Convert.ToDouble(strNot2);
            double not3 = Convert.ToDouble(strNot3);

            double notOrtalama = (not1 + not2 + not3) / 3;

            if (notOrtalama >= 90)
            {
                Console.WriteLine("Harf Notu: AA");
            }
            else if (notOrtalama >= 80)
            {
                Console.WriteLine("Harf Notu: BA");
            }
            else if (notOrtalama >= 70)
            {
                Console.WriteLine("Harf Notu: BB");
            }
            else if (notOrtalama >= 60)
            {
                Console.WriteLine("Harf Notu: CB");
            }
            else 
            {
                Console.WriteLine("Harf Notu: FF");
            }
        }
    }
}

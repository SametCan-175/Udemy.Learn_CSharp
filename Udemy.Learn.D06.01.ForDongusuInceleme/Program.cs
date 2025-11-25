namespace Udemy.Learn.D06._01.ForDongusuInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              for(baslangıç: kosul: artış:)
               {
                    tekrarlamasını istediğimiz işlemlerimizi bu alana yazarız.
               }
             */

            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(i);
            }
            int toplam = 0;
            for (int i = 0; i <= 10; i++)
            {
                toplam = toplam + i;
                
            }
            Console.WriteLine(toplam);
        }
    }
}

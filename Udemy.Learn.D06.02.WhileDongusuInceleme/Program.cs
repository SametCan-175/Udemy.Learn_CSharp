namespace Udemy.Learn.D06._02.WhileDongusuInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //Console.WriteLine("Sonsuz Döngü Başladı");
            //}

            int toplam = 0;
            int sayac = 1;

            while(sayac <= 20)
            {
                toplam= toplam+sayac;
                sayac++;
            }
             Console.WriteLine("Toplam değer: "+toplam);
        }
    }
}

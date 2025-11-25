namespace Udemy.Learn.D04._01AritmetikselIslemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aritmetiksel İşlemler 
            /*
             * + Toplama
             * - Çıkarma
             * * Çarpma
             * / Bölme
             * % Mod Alma
             */

            //Toplama Operatörü Kullanımı 

            int sayi1 = 10;
            int sayi2 = 20;

            int toplam= sayi1 + sayi2;
            
            //Çıkarma Operatörü

            int cıkarma = sayi1 - sayi2;
            cıkarma = sayi2 - sayi1;

            //Bölme Operatörü

            decimal sayi3 = 10;
            decimal sayi4 = 5;
            decimal bolme = sayi3 / sayi4;

            //Carpma Operatörü 

            decimal sayi5 = 10;
            decimal sayi6 = 5;
            decimal carpma = sayi5 * sayi6;

            //Mod Alma
            int sayi7 = 10;
            int sayi8 = 2;

            int ModAlma = sayi7 % sayi8;

        }
    }
}

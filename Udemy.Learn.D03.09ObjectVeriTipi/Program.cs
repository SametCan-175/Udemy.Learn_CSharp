namespace Udemy.Learn.D03._09ObjectVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object ObjectV1 = 10;
            object ObjectV2 = "Merhaba";
            object ObjectV3 = true;
            object ObjectV4 = 45.45;

            int Sayi1 = 100;
            object ObjectV5 = Sayi1;   // Boxing -Kutulama
            int sayi2 = (int)ObjectV5;

            var x = 45.45;
            //x = "Merhaba";      olmaz

        }
    }
}

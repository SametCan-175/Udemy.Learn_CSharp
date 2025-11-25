namespace Udemy.Learn.D03_08.TurDonusmleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konu: Bilinçli Tür Dönüşümleri
            // Örnek 1 :
            double doubledegerI = 56.90;
            int intdegerI = (int)doubledegerI;

            // Örnek 2 :
            long longdegerI = 12345678909;
            int intDegerII = (int)doubledegerI;

            //Örnek 3 :
            object objectDegerI = "Samet Can Şanal";
            string metinI = (string)objectDegerI;

            //Konu Bilinçsiz Tür Dönüşümleri
            //Örnek 1 :

            int intDegerIII = 9000;
            double doubleDegerII = intDegerIII;

            byte byteDegerIII = 255;
            long longDegerIII = byteDegerIII;

        }
    }
}

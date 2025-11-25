namespace Udemy.Learn.D04._04KarsilastirmaOperatörleriInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 15;

            // ==Eşit mi kontrolü

            bool esitmi = sayi1 == sayi2;
            
            // =!Eşit değl  mi kontrolü
            
            bool esitDegilmi = sayi1 != sayi2;

            // > Büyük mü  kontrolü
            
            bool buyukmu = sayi1 > sayi2;

            // < Küçük mü Kontrolü

            bool kucukmu = sayi1 < sayi2;

            // >= Büyük eşit mi kontrolü

            sayi1 = 20;
            sayi2 =19;

            bool Buyukesitmi = sayi1 >= sayi2;

            // <= Küçük eşit mi kontrolü

            bool Kucukesitmi =sayi1 <= sayi2;
        }
    }
}

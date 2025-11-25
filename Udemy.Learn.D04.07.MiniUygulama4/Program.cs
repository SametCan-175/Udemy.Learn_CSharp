namespace Udemy.Learn.D04._07.MiniUygulama4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dakika degerini oğrenmek istediginiz saat bilgisini giriniz");
            string KullaniciSaatBilgisi = Console.ReadLine();

            double SaatBilgisi = Convert.ToDouble(KullaniciSaatBilgisi);
            int ToplamDakika = (int)SaatBilgisi * 60;

            Console.WriteLine("Dakika degeri :" + ToplamDakika);
            Console.WriteLine($"Dakika degeri : {ToplamDakika}");
        }
    }
}

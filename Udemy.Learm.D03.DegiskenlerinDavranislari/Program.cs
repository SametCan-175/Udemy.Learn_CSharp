namespace Udemy.Learm.D03.DegiskenlerinDavranislari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal urunFiyat = 100;
            decimal urunIndirimFiyat = urunFiyat;
            urunIndirimFiyat = 50;

            Console.WriteLine(urunFiyat);
            Console.ReadLine();
        }
    }
}

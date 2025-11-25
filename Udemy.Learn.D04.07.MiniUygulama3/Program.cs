namespace Udemy.Learn.D04._07.MiniUygulama3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double urunFiyat = 1000;
            double yeniFiyat = 1000;

            double indirimYuzde = ((urunFiyat - yeniFiyat)/ urunFiyat) * 100 ;
            bool urunİndirimDurumu = urunFiyat > yeniFiyat;

            Console.WriteLine(urunİndirimDurumu?"Ürün indirim kapsamında ":"Ürün indirimde değil ");
            Console.WriteLine("Ürün % indirim " + indirimYuzde);
            Console.WriteLine(urunİndirimDurumu);
        }
    }
}

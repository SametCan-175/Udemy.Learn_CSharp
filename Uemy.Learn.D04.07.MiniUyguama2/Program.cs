namespace Uemy.Learn.D04._07.MiniUyguama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcııdan isim soyisim ve doğum tarihini isteyelim.Girilen doğum tarihine göre kullanıcının yaş değerini ekran yazalım.

            Console.WriteLine("isim  ve soyisim değerlerini giriniz: ");
            string tamad = Console.ReadLine();

            Console.Write("Doğum tarihinizi (yyyy-MM-dd) olarak giriniz");
            string dogumTarihi= Console.ReadLine();

            DateTime KullaniciDogumTarih=Convert.ToDateTime(dogumTarihi);
            DateTime bugün= DateTime.Now;


            int KullaniciYas = bugün.Year - KullaniciDogumTarih.Year;

            Console.WriteLine("Yaşınız" + KullaniciYas);

        }
    }
}

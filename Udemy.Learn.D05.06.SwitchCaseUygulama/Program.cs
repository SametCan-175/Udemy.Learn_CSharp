namespace Udemy.Learn.D05._06.SwitchCaseUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Degeri Giriniz: ");
            string deger1 = Console.ReadLine();

            Console.WriteLine("2.Degeri Giriniz");
            string deger2= Console.ReadLine();

            Console.WriteLine("İslem Seciniz");
            Console.WriteLine("1-TOPLAMA");
            Console.WriteLine("2-ÇIKARMA");
            Console.WriteLine("3-ÇARPMA");
            Console.WriteLine("4-BÖLME");

            string KullaniciSecim = Console.ReadLine();

            double dgr1=Convert.ToDouble(deger1);
            double dgr2=Convert.ToDouble(deger2);

            double islemSonuc = 0;
            switch (KullaniciSecim)
            {
                case "1":
                    islemSonuc = dgr1 + dgr2;
                    break;
                case "2":
                    islemSonuc = dgr1 - dgr2;
                    break;
                case "3":
                    islemSonuc = dgr1 * dgr2;
                    break;
                case "4":
                    islemSonuc = dgr1 / dgr2;
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim Yaptınız!");
                    break;

              
            }
            Console.WriteLine("İşlem Sonucunuz: "+islemSonuc);
        }
    }
}

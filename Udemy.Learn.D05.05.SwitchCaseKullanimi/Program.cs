namespace Udemy.Learn.D05._05.SwitchCaseKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switch (deger)
            // {
            //     case sabitdeger1:
            //         break;
            //     case sabitdeger2:
            //         break;
            //         default:
            //         break;
            // }


            Console.WriteLine("Lütfen işlem seçiniz");
            Console.WriteLine("1.Su");
            Console.WriteLine("2.Çay");
            Console.WriteLine("3.Kahve - Türk");
            Console.WriteLine("4.Kahve - Filtre");

            string KullaniciSecim = Console.ReadLine();
            switch (KullaniciSecim)
            {
                case "1":
                    Console.WriteLine("Su veriliyor....");
                    break;
                case"2":
                    Console.WriteLine("Çay veriliyor....");
                    break;
                case"3":
                    Console.WriteLine("Kahve - Türk Veriliyor....");
                    break;
                case "4":
                    Console.WriteLine("Kahve - Filtre veriliyor....");
                    break;
                default:
                    Console.WriteLine("Hatalı işlem seçtiniz");
                    break;
            }
        }
    }
}

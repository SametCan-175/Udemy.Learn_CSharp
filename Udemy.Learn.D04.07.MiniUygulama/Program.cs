using System.Threading.Channels;

namespace Udemy.Learn.D04._07.MiniUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merhaba İsminiz Giriniz");
            string kullaniciadi= Console.ReadLine();

            Console.WriteLine(kullaniciadi + "notlarınız hesaplamak için lütfen giriş yapınız ");

            Console.Write("1. Notunuzu Giriniz ");
            string strnot1 = Console.ReadLine();

            Console.Write("2. Notunuzu Giriniz ");
            string strnot2  = Console.ReadLine();

            Console.Write("3. Notuuzu Giriniz ");
            string strnot3 = Console.ReadLine();

            double dbNot1= double.Parse(strnot1);
            double dbNot2= Convert.ToDouble(strnot2);
            double dbNot3= double.Parse(strnot3);

            double OrtNot = 0;
            
            // 1.Yöntem 

            double ToplamNot=(dbNot1+dbNot2 + dbNot3);
            OrtNot = ToplamNot / 3;
            //2.Yöntem 

            double OrtNo= (dbNot1 + dbNot2 + dbNot3) / 3;

            string KullaniciNotMesaj = (OrtNot >= 45) ? "ortalamanız 45'e eşit ve büyük olduğu için geçtiniz": " ortalamanız 45 ten küçük olduğu için kaldınız ";
            Console.WriteLine(KullaniciNotMesaj);
        }
    }
}

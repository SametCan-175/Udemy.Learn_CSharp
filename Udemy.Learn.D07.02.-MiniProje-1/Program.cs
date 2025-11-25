using System.Threading.Channels;

namespace Udemy.Learn.D07._02._MiniProje_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Toplamak istediğiniz kaç adet sayı vardıı ?");
            int adet = int.Parse(Console.ReadLine());

            int[] sayilar = new int[adet];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(i + ". değeri giriniz: ");
                sayilar[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tüm değerlerinizi girdiniz. Şimdi toplama işlemini başlatalım. ");

            int toplamDeger = 0;
            foreach (var item in sayilar)
            {
                toplamDeger += item;
            }
            Console.WriteLine("Toplam :" + toplamDeger);
        }
        

    }
}

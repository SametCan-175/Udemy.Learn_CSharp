namespace Udemy.Learn.D05._01IfKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double urunFiyati = 3000;

            string KullaniciMesaji = (urunFiyati >= 3000) ? "Ürün Fiyatı 3000 den büyük veya eşit " : " Ürün Fiyatı 3000 den küçük ";

            Console.WriteLine(KullaniciMesaji);

            /*
            if(kosul veya kosullar ) True
        {
            işlemler yapılır
        }
            */
            if (urunFiyati >= 3000)//Doğru ise ;
            {
                Console.WriteLine("Kod 1");
                Console.WriteLine("Kod 2");
                Console.WriteLine("Kod N");
            }
            else if (urunFiyati >= 2000)
            {
                Console.WriteLine("Ürün fiyatı 2000 değerine eşit veya büyük");

            }
            else if (urunFiyati >= 1000)
            {
                Console.WriteLine("Ürün fiyatı 1000 değerine eşit veya büyük");
            }
            else
            {
                //Eğer yukarıda bulunan şart veya şartlar sağlanmaz ise yapılmasını istediğimiz işlemleri bu alana yazarız.

                Console.WriteLine("Kod X");
                Console.WriteLine("Kod Y");
            }
        }
    }
}

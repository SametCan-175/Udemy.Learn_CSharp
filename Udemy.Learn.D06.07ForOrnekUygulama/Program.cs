namespace Udemy.Learn.D06._07ForOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Kaç farklı harcama girişi yapmak istiyorsun: ");
                string strHarcamaAdedi = Console.ReadLine();
                int adet = Convert.ToInt32(strHarcamaAdedi);

                decimal toplam = 0;
                decimal enDusuk = decimal.MaxValue;
                decimal enYuksek = decimal.MinValue;

                for (int i = 1; i <= adet; i++)
                {
                    Console.Write(i + ".harcama tutarını giriniz TL :");
                    //string strHarcamaTutari = Console.ReadLine();
                    //decimal harcama=decimal.Parse(strHarcamaTutari);

                    bool HarcamaTutariDogruMu = decimal.TryParse(Console.ReadLine(), out decimal harcama);

                    if (HarcamaTutariDogruMu == false)
                    {
                        Console.WriteLine("Geçersiz bir giriş yaptınız !");
                        continue;
                    }

                    if (harcama <= 0)
                    {
                        Console.WriteLine("Harcama degeriniz 0 veya altında olmalıdır. ");
                        i--;
                        continue;
                    }

                    toplam += harcama;

                    if (harcama > enYuksek) enYuksek = harcama;
                    if (harcama < enDusuk) enDusuk = harcama;
                }

                decimal ortalamaHarcama = toplam / adet;

                Console.WriteLine("Toplam Harcama : " + toplam);
                Console.WriteLine("Ortalama Harcama: " + ortalamaHarcama);
                Console.WriteLine("En Yuksek Harcama: " + enYuksek);
                Console.WriteLine("En Dusuk Harcama:" + enDusuk);
            }
        }
    }
}

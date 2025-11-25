namespace Udemy.Learn.D05._03IfOrnekKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1.degeri giriniz");
            string deger1 = Console.ReadLine();

            Console.WriteLine("lütfen 2.degeri giriniz.");
            string deger2 = Console.ReadLine();

            Console.WriteLine("1-TOPLAMA");
            Console.WriteLine("2-ÇIKARMA");
            Console.WriteLine("3-ÇARPMA");
            Console.WriteLine("4-BÖLME");

            double dgr1 =Convert.ToDouble(deger1);

            double dgr2 = Convert.ToDouble(deger2);

            Console.WriteLine("işlemi seçiniz ");
            string islem = Console.ReadLine();

            double islm= Convert.ToDouble(islem);

            if (islem == "1")
            {
                Console.WriteLine("Toplama işlemini seçtiniz: " + (dgr1 + dgr2));
            }
            else if (islem == "2")
            {
                Console.WriteLine("Çıkarma işlemini seçtiniz: " + (dgr1 - dgr2));
            }
            else if (islem == "3")
            {
                Console.WriteLine("Çarpma işlemini seçtiniz: " + (dgr1 * dgr2));
            }
            else if(islem == "4") 
            {
                Console.WriteLine("Bölme İşlemini seçtiniz: " +(dgr1 / dgr2));
            }
            else
            {
                Console.WriteLine("Size verilen işlem tablosundan ayrı bir veri seçtiniz");
            }

        }
    }
}

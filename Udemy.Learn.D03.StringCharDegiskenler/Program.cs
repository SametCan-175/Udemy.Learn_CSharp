namespace Udemy.Learn.D03.StringCharDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Samet Can";

            string soyad = "Şanal";

            Console.WriteLine("Adınızı giriniz:");
            string kullanıcıadı = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            string kullanıcısoyadı= Console.ReadLine();

            Console.WriteLine(kullanıcıadı);
            Console.WriteLine(kullanıcısoyadı);
        }
    }
}

using System.ComponentModel.Design;

namespace Udemy.Learn.D05._02IfOrnekKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Kullanıcı adınızı giriniz: ");
            string KullaniciAdi = Console.ReadLine();

            Console.WriteLine("Şifrenizi Giriniz: ");
            string sifre = Console.ReadLine();

            if (KullaniciAdi == "Samet" && sifre == "Samet4220")
            {
                Console.WriteLine("Kullanıcı bilgileriniz doğru");


            }
            else
            {
                Console.WriteLine("kullanıcı bilgileriniz yanlış");
            }
            
            
        }
        
    }
    
}


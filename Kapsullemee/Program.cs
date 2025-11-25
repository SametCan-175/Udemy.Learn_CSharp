using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsullemee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            //M1.id = 1;
            //M1.isim = "Samet Can";
            //M1.soyad = "Şanal";


            /*
             *Field değer ataması yapılmasın ama değer okunabilsin  
             *Field değer ataması yapılsın ama değer okunmasın
             *Field değer ataması yapılsın ama değerin ilk 4 hanesi okunsun 
             *Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde 
              bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin 
             */


            /* 
             * Class
             * Field 
             * Property
             * Get & Set
             */

            // M1.emailAdres = "sametcansanal4@gmail.com";  // (Field)
            //Genel olarak kapsülleme konusuna giriş yaptık
            //M1.EmailAdres = "sametcansanal4@gmail.com";

            //1.Field değer ataması yapılmasın ama değer okunabilsin.
            Console.WriteLine("Musteri Id Degeri =" + M1.ID.ToString());
            M1.ID = 10;

        }
    }
}

using System;  // Bir kutuphane dosyasını uygulamamızın içerisine eklemektir.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D09._01.MetotGenelTanım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uzun bir şekilde yazım.
            //System.Console.Write("Merhaba");
            //using kısmında kütüphane eklenmiş hali ile yazımı .
            //Console.Write("Merhaba");
            //Selamla();

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.selamlaOgrenci();
        }
        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
  
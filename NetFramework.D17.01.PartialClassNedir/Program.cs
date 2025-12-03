using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D17._01.PartialClassNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id = 1;
            m1.ad = "Samet";
            m1.soyad = "Şanal";
            m1.email = "sametcansanal4@gmail.com";

            int sonuc = m1.yeniKayit(m1);
            if (sonuc > 0)
            {
                Console.WriteLine("database yeni kayıt eklnedi");
            }

            ogrenci o1 = new ogrenci();
            o1.id = 1;
            o1.yeniKayit(o1);
        }
    }
}

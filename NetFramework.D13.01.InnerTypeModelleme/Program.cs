using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D13._01.InnerTypeModelleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.MusteriId = 1;
            M1.tcKimlikNumarası = "12345678901";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.olusturmaTarih = DateTime.Now

            M1.musteriAdresListe[0] = new MusteriAdres[5];

        }
    }
}

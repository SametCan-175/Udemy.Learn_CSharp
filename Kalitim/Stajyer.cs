using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Stajyer:Calisan
    {
        private int stajSuresi {  get; set; }

        public Stajyer(String ad, String soyad, int maas,int stajSuresi):base(ad,soyad,maas)
        {

            this.stajSuresi = stajSuresi;
        }
        public override void Calistir()
        {
            Console.WriteLine("Stajyer çalışıyor: ");
            Console.WriteLine("staj süresi: " + stajSuresi);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Kalitim
{
    internal class Calisan
            
    {
        private string ad;
        private string soyad;
        private int maas;


        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { this.soyad = value; }

        }
        public int Maas
        {
            get { return maas; }
            set { this.maas = value; }

        }
        public Calisan(string ad, string soyad, int maas)
        {
            Ad = ad;
            this.soyad = soyad;
            this.maas = maas;
        }
        
        public virtual void Calistir()
        {
            Console.WriteLine("çalışan çalışıyor."+ad+""+soyad+"");
        }
        

    }
}

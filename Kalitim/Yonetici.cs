using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Yonetici:Calisan
    {
        private string departman;
        public string Departman
        {
            get { return departman; }
            set { this.departman = value; }
        }
        public Yonetici(String ad,String soyad,int maas,string departman):base(ad,soyad,maas)
        {
            this.departman=departman;
        }
        public override void Calistir()
        {
            Console.WriteLine("Yönetici Çalışıyor...");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeHazirlik
{
    internal class Kamyonet:Ozellikler
    {
        private double yukseklik;
        public double Yukseklik { 
            get { return yukseklik; }
            set { yukseklik = value; }
        }
        
        public Kamyonet(string marka,string model,string yakitturu,double yukseklik, bool bakimdurumu) : base(marka, model, yakitturu,bakimdurumu)
        {
            Marka = marka;
            Model = model;
            Yakitturu = yakitturu;
            Yukseklik= yukseklik;
        }
        public override void Hizlanma()
        {
            Console.WriteLine("Kamyonet Hızlanıyor..."+Marka+" "+Model+" "+Yakitturu+" "+Yukseklik+" "+bakimdurumu);
        }
        public override void Frenleme()
        {
            Console.WriteLine("Kamyonet Frenliyor..." + Marka + " " + Model + " " + Yakitturu + " " + Yukseklik);
        }
    }
}

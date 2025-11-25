using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeHazirlik
{
    internal class Motorsiklet:Ozellikler
    {
        private int fiyat;
        public int Fiyat
            { get { return fiyat; }
            set { fiyat = value; } 
        }
        public Motorsiklet(string marka, string model, string yakitturu,int fiyat,bool bakimdurumu) : base(marka, model, yakitturu,bakimdurumu)
        {
            Marka = marka;
            Model = model;
            Yakitturu = yakitturu;
            Fiyat = fiyat;
        }
        public override void Hizlanma()
        {
            Console.WriteLine("Motorsiklet Hızlanıyor..."+Marka+" "+Model+" "+Yakitturu+" "+Fiyat+" "+bakimdurumu);
        }


       
        
    }
    
}

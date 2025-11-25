using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VizeHazirlik
{
    internal class Otomobil:Ozellikler
    {
        private string renk;
        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }
        public Otomobil(string marka, string model, string yakitturu,string renk,bool bakimdurumu) : base(marka, model, yakitturu,bakimdurumu)
        {
            Marka= marka;
            Model= model;
            Yakitturu= yakitturu;
            Renk = renk;
        }
        public override void Hizlanma()
        {
            Console.WriteLine("Otomobil hızlaniyor..."+Marka+" "+Model+" "+Yakitturu+" "+Renk+" "+bakimdurumu);
        }
        public override void Frenleme()
        {
            Console.WriteLine("Kamyonet Frenliyor..." + Marka + " " + Model + " " + Yakitturu + " " + Renk);
        }
    }
}

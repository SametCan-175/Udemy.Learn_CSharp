using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeHazirlik
{
    internal class Ozellikler
    {
            private string marka;
            private string model;
            private string yakitturu;
            public bool bakimdurumu {  get; set; }

            public string Marka { get { return marka; } set { marka = value; } }
            public string Model { get { return model; } set { model = value; } }
            public string Yakitturu { get { return yakitturu; } set { yakitturu = value; } }

        public Ozellikler(string marka, string model, string yakitturu,bool bakimdurumu )
        {
            Marka = marka;
            Model = model;
            Yakitturu = yakitturu;
            
        }
        public void AracBilgisi()
        {
            Console.WriteLine("Marka" + marka);
            Console.WriteLine("Model"+model);
            Console.WriteLine("Yakıt Türü"+yakitturu);
        }
        public virtual void Hizlanma()
        {
            Console.WriteLine("Bu araç Hızlanıyor...");
        }
       
        public virtual void Frenleme()
        {
            Console.WriteLine("Bu Araç Frenliyor...");
        }
       
    }
}

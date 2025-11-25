using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D14._01.KalitimNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            temelTip T1 = new temelTip();
            T1.TemelTipMetot1();

            Egitmen E1 = new Egitmen();
            Console.WriteLine("Eğitmen nesnesi örneklendi");
            E1.TemelTipMetot1();


            //Özel tiplerde Boxing ve Unboxing 

            //Bizim object nesnemiz nedir ?
            // Temel Tip
            temelTip T2;
            //Hangi nesnelerde temeltip object görevi görür...
            //Personel Eğitmen Ogrenci.
            //Temeltip nesnesinden turedikleri için temel tip nesnesi bu nesnelerde object gibi davranır.

            T2 = E1;
            E1 = (Egitmen)T2;

            Personel P1= new Personel();
            T2 = P1; //Personel nesnesini temeltip nesnesine atadık.

            Ogrenci O1 = new Ogrenci();
            T2 = O1;//Ogrenci nesnesini Temeltip nesnesine atadık. 

            O1 = (Ogrenci)T2;

            //object O3 = T2;



            //Boxing -- Unboxing 

            // object O1 = E1;   //  Boxing
            // E1 = (Egitmen)01; //  Unboxing







        }
    }
}

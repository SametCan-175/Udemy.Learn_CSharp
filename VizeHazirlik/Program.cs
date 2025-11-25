using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizeHazirlik
{

    internal class Program
    {



        static void Main(string[] args)
        {
            Otomobil O1= new Otomobil("Toyota","Coralla","Benzin","Mavi",true);
            O1.Hizlanma();
            O1.Frenleme();
            Motorsiklet m1 = new Motorsiklet("Tvs", "Raider125", "Benzin", 100000,false);
            m1.Hizlanma();
            m1.Frenleme();
            Console.WriteLine();
            Kamyonet K1 = new Kamyonet("Mercedes", "515CD", "Mazot", 13.4, true);
            m1.Hizlanma();
            m1.Frenleme();
            Console.WriteLine();

        }
    }
}

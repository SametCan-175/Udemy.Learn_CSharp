using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D12._02.PersonelUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel P1 = new Personel();
            P1.isim = "Samet Can";
            P1.soyisim = "Şanal";
            P1.cinsiyet = 42; //BAY -42 ,BAYAN 43
            P1.EmailAdres = "SAMETCANSANAL4";

        }
    }
}

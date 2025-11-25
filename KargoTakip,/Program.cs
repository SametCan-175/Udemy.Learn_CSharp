using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kargo kargo = new Kargo("1456412","Samet Bilişim","Ozan",10,41.4,true);
            kargo.KargoBilgisi();
            kargo.UcretHesaplama();
            Console.ReadLine();
        }
    }
}

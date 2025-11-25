using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yonetici Y1 = new Yonetici("Samet","Şanal",60000,"IT");
            Stajyer S1 = new Stajyer("Ali", "Veli", 30000, 60);
            Y1.Ad = "";
        }
    }
}

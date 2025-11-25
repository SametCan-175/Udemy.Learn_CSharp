using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D15._01.SanalMetotNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Televizyon T1 = new Televizyon();
            T1.ekranaYaz("Hangisi? ");

            urun U1= new urun();
            U1.ekranaYaz("merhaba");

            baseClass B1 =new baseClass();
            B1.ekranaYaz("Merhaba");

        }
    }
}

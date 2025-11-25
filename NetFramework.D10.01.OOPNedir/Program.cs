using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D10._01.OOPNedir
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Arac Sınıfı İnceleme
            Arac A1 = new Arac("Opel","Corsa",2010,56000);
            A1.AlisFiyat = 28000;
            A1.SatisFiyat = 32000;
            A1.MaxIndirimTutar = 1500;
            //A1.Fiyat= Kapsülleme konusu...
            A1.FiyatAta(31000);
            A1.BilgileriGoruntule();
            #endregion
            Musteri M1 = new Musteri();
            M1.TcKimlik = "10370096770";
            M1.İsim = "Samet Can";
            M1.Soyİsim = "Şanal";
            M1.Cinsiyet = 42;
        }
    }
}
      
    
         

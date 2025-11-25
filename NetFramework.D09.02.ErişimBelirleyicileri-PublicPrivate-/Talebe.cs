using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D09._02.ErişimBelirleyicileri_PublicPrivate_
{
    public class Talebe
    {
        public void selamTalebe()
        {
            Console.WriteLine("Merhaba Öğrenci");

        }
        /*
         * 
         * [Erişim Belirleyicisi] <GeriDonusDegeri> MetotAdi (Parametreler)
         * {
         *       Metot için gereken kodlar...
         *  }
         *  Erişim Belirlecisi
         * 
         * Public
         * Private
         * Protected
         * Internal
         * Internal Protected
         * 
         */

        private void OgrenciMetot1(string ogrenciiadi, string ogrencisoyadi)
        {
            Console.WriteLine("Öğrenci Bigileri: {0} {1}",ogrenciiadi,ogrencisoyadi);
        }
        public void OgrenciMetot2()
        {
            OgrenciMetot1("Cengiz", "Atilla");
        }
    }
}

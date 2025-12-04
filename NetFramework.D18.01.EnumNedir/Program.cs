using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D18._01.EnumNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            m1.id= 1;
            m1.musteriNumara = "MSN001";
            m1.isim = "Samet Can ";
            m1.soyisim = "Şanal";
            m1.email = "sametcansanal4@gmail.com";

            sanalDatabase sb = new sanalDatabase();
            musteriReturnValue musteriKayitSonuc = sb.musteriYeniKayit(m1);

            if (musteriKayitSonuc == musteriReturnValue.kayitBasarili)
            {

            }
        }
    }
}

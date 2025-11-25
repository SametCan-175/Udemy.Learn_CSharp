using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D13._01.InnerTypeModelleme
{
    public class Musteri
    {
        #region Tekil olarak kullanılan field 
        public int MusteriId { get; set; }
        public string tcKimlikNumarası { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
        #endregion

        #region InnerType gerektiren field lar
        public MusteriAdres[] musteriAdresListe;
        public MusteriIletisimBilgisi[] musteriIletisimBilgileri;
        public MusteriSiparisBilgisi[] musteriSiparisBilgisis;
        #endregion
    }

}



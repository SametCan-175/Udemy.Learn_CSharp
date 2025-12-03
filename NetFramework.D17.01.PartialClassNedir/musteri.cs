using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D17._01.PartialClassNedir
{
    public class musteri
    {
        #region Fields
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string email { get; set; }
        #endregion

        #region Metot
        public int yeniKayit (musteri m)
        {
            Console.WriteLine("database kayıt işlemi tamamlandı");
            return 1;
        }
        public int kayitGuncelle (musteri m)
        {
            Console.WriteLine("musteri kaydı güncellendi ");
            return 1;
        }
        public int kayitSil (int id)
        {
            Console.WriteLine("musteri kaydı silindi ");
            return 1;
        }
        #endregion

    }
}

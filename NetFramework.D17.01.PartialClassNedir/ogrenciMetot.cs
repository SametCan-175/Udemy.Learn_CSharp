using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D17._01.PartialClassNedir
{
    public partial class ogrenci
    {
        public int yeniKayit(ogrenci o)
        {
            Console.WriteLine("database kayıt işlemi tamamlandı");
            return 1;
        }
        public int kayitGuncelle(ogrenci o)
        {
            Console.WriteLine("ogrenci kaydı  güncelleme başarılı ");
            return 1;
        }
        public int kayitSil(int id)
        {
            Console.WriteLine("ogrenci silindi ");
            return 1;
        }
    }
}

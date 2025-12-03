using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D16._02.InterfaceNedir
{
    public class musteri : Imusteri1
    {
        int _id;
        string _isim;
        string _soyisim;

        public int Id { get { return _id; } set { _id = value; } }
        public string isim { get { return _isim; ; } }
        public string soyisim { get { return _soyisim; } set { _soyisim = value; } }

        string Imusteri1.isim { get => isim; set => throw new NotImplementedException(); }

        public int kayyitSil(int Id)
        {
            Console.WriteLine("Kayıt Silindi");
            return 1;
        }
        public int kayitDuzenle(int Id, string isim, string soyisim)
        {
            Console.WriteLine("Kayıt Duzenlendi");
            return 1;
        }
        public int yeniKayit(string isim, string soyisim)
        {
            Console.WriteLine("Kayıt Eklendi");
            return 1;
        }
    }
}

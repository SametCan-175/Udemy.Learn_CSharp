using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D16._02.InterfaceNedir
{
    public interface Imusteri1
    {
        //public musteri1()
        //{ 
        //}
        // interface'lerde constructor tanımlanamaz...

        //field 
        int Id { get; set;}
        string isim { get;set; }
        string soyisim { get;set; }
        //metot
        int yeniKayit(string isim, string soyisim);
        int kayitDuzenle(int Id, string isim, string soyisim);
        int kayyitSil(int Id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameWork.D12._01.StaticNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static : nesne örneği alınmadan ulaşabildiğimiz metot ,field , sınıf..
            // Tip M1 = new Tip();
            // Tip.

            // Stack bölge içersinde pointer ımız oluştu... 
            Ogrenci O1;
            // Stack bölgede pointer oluştuğu zaman static olan bir yapıcı metot çalıştı ve yine class içerisinde tanımlı olan static field, metot static 
            // dediğimiz bölgede oluşturuldu.
             Ogrenci.Test2();

            O1 = new Ogrenci();
            // Stack bölgede pointer => kendisini heap bölgede tamamladı.. static olmayan tanımlarını tamamladı...
            O1.Test1(); // nesne örneği alındıktan sonra test1 adındaki metotuma ulaşabildim.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameWork.D12._01.StaticNedir
{
    public class Ogrenci //internal 
    {
        public string isim {  get; set; }
        public string Soyİsim { get; set; }
        public string EmailAdres { get; set; }

        public void Test1()
        {
            Console.WriteLine("Nesne örneği alındıktan sonra çalışan metot ");
        }

         public static  void Test2()
        {
            Console.WriteLine("Nesne örneği ALINMADAN kullanılabilir. ");
        }

    }
}

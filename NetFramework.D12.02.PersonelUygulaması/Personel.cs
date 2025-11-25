using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D12._02.PersonelUygulaması
{
    public class Personel
    {
        public static string domainAdres = "firmam";
        public string isim { get; set; }
        public string soyisim {  get; set; }
        public int cinsiyet {  get; set; }
        private string emailAdres {  get; set; }
        public string EmailAdres 
        {
            get
            {
                return this.emailAdres;
            }
            set
            {
                this.emailAdres = value.ToLower()+"@"+domainAdres;
            }
        }
    }   
}

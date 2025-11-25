using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D13._01.InnerTypeModelleme
{
    public class MusteriIletisimBilgisi
    {
        public int iletisimTip {  get; set; }//71770001 : Mobil - 71770002 : Sabit Hat
        public string alankodu { get; set; }
        public string numara {  get; set; }
        public bool AktifPasif {  get; set; }
    }
}

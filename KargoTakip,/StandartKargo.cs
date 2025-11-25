using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip_
{
    internal class StandartKargo:Kargo
    {
        private int teslimsuresi;
        public int Teslimsuresi
        {
            get { return teslimsuresi; }
            set { teslimsuresi = value; }
        }
        public StandartKargo(string gonderinumarasi,string gonderici,string alici,int  ucret,double agirlik,bool teslimDurum,int teslimsuresi):base(gonderinumarasi,gonderici,alici,ucret,agirlik,teslimDurum)
        {
            this.teslimsuresi = teslimsuresi;
        }
    }
}

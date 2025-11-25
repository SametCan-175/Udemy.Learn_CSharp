using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip_
{
    internal class HizliKargo : Kargo
    {
        private double ekucret;
        public double Ekucret { 
            get
            { return ekucret; }
            set
                { ekucret = value; }
            }
        public HizliKargo(string gonderiNumarasi, string gonderici, string alici, int ucret, double agirlik, bool teslimDurum,double ekucret) : base(gonderiNumarasi, gonderici, alici, ucret, agirlik, teslimDurum)
        {
            this.ekucret = ekucret;
        }
        public override void UcretHesaplama()
        {
            Console.WriteLine("50 TL ücrete eklendi"+ (base.Ucret + 50));
        }
    }
}

using System;

namespace KargoTakip_
{
    internal class KirilabilirKargo:Kargo
    {
        private bool ozelPaket;
        public bool OzelPaket
        {   
            get
            {
                return ozelPaket;
            }
            set
            {
                ozelPaket = value;
            }
        }
        public KirilabilirKargo(string gonderiNumarasi,string gonderici,string alici,int ucret,double agirlik,bool teslimsuresi,bool ozelpaket) : base(gonderiNumarasi, gonderici, alici, ucret, agirlik, teslimsuresi)
        {
            this.ozelPaket=ozelpaket;
        }
        public override void UcretHesaplama()
        {
            if (ozelPaket == true)
            {
                Console.WriteLine("extra ucret 25 TL eklendi"+(base.Ucret+25));
            }
        }
    }
}

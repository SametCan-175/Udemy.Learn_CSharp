using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakip_
{
    internal class Kargo
    {
        private String gonderiNumarasi;
        public String GonderiNumarasi
        {
            get { return gonderiNumarasi; }
            set { gonderiNumarasi = value; }
        }
        private String gonderici;
        public String Gonderici
        {
            get { return gonderici; }
            set { gonderici = value; }
        }
        private String alici;
        public String Alici
        {
            get { return  alici; }
            set { alici = value; }
        }
        private int ucret;
        public int Ucret
        {
            get { return ucret; }
            set { 
                if(value>0)
                {
                    ucret = value;
                }
                else
                {
                    Console.WriteLine("Ücret sıfırdan küçük olamaz!");
                }
            }
        }
        private double agirlik;
        public double Agirlik
        {
            get { return agirlik; }
            set { agirlik = value; }
        }
        private bool teslimDurum;
        public bool TeslimDurum
        {
            get { return  teslimDurum; }
            set { teslimDurum = value; }
        }
        public Kargo(string gonderiNumarasi, string gonderici,string alici, int ucret, double agirlik, bool teslimDurum)
        {
            this.gonderiNumarasi = gonderiNumarasi;
            this.gonderici = gonderici;
            this.alici = alici;
            this.agirlik = agirlik;
            this.ucret = ucret;
            this.teslimDurum= teslimDurum;
        }

        public void KargoBilgisi()
        {
            Console.WriteLine("Gonderici Numarası:" + gonderiNumarasi);
            Console.WriteLine("Gonderici:"+Gonderici);
            Console.WriteLine("Alıcı:" + alici);
            Console.WriteLine("Kargo Ücreti:" + ucret);
            Console.WriteLine("Kargo Ağırlığı:" + agirlik);
            Console.WriteLine("Teslim Durumu:"+teslimDurum);
        }
        public virtual void UcretHesaplama()
        {
            double tutar = ucret * agirlik;
            Console.WriteLine("tutar"+tutar);
        }

    }
}

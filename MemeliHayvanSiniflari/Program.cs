using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MemeliHayvanSiniflari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopekler K1 = new Kopekler("Pitbull",4,"Dişi",10.52,"Siyah");
            K1.SesCıkar();
            Console.WriteLine();
            Kediler Ke1 = new Kediler("british", 2, "Erkek", 4.20, true);
            Ke1.SesCıkar();
            Console.WriteLine();
            Yunuslar y1 = new Yunuslar("Yunus", 3, "Erkek", 210.2, 130);
            y1.SesCıkar();
            Console.WriteLine();
            Filler F1 = new Filler("Afrika", 5, "Dişi", 300.2, 300); 
            F1.SesCıkar();
            Console.WriteLine();
        }
    }
    public class Kediler:MemeliHayvan
    {
        private bool evcil;
        public bool Evcil
        {
            get { return evcil; }
            set { evcil = value; }
        }


        public Kediler(string tur,int yas,string cinsiyet,double agirlik,bool evcil): base (tur,yas,cinsiyet,agirlik) 
        { 
            this.evcil = evcil;
        }
        public override void SesCıkar()
        {
            Console.WriteLine("Kedi Miyavlıyor..."+getTur()+" "+getCinsiyet()+" "+getAgirlik()+" "+evcil);
        }
    }
    public class Kopekler:MemeliHayvan
    {
        private string renk;
        public string Renk {
            get { return renk; } 
            set { renk = value; }
        }
        public Kopekler(string tur, int yas, string cinsiyet, double agirlik,string renk) : base(tur, yas, cinsiyet, agirlik)
        {
            this.renk = renk;
        }
        public override void SesCıkar()
        {
            Console.WriteLine("Köpek havlıyor..."+getTur()+" "+getCinsiyet()+" "+getAgirlik()+" "+renk);
        }
    }
    public class Yunuslar:MemeliHayvan
    {
        private int iq;
        public int IQ
        {
            get { return iq; }
            set { iq = value; }
        }
        public Yunuslar(string tur, int yas, string cinsiyet, double agirlik,int iq) : base(tur, yas, cinsiyet, agirlik)
        {
            this.iq = iq;
        }
        public override void SesCıkar()
        {
            Console.WriteLine("Yunus ses çıkarıyor..." + getTur() + " " + getCinsiyet() + " " + getAgirlik() + " " +iq);
        }
    }
    public class Filler:MemeliHayvan
    {
        private int buyukluk;
        public int Buyukluk { 
            get { return buyukluk; }
            set { buyukluk = value; }
        }
        public Filler(string tur, int yas, string cinsiyet, double agirlik,int buyukluk) : base(tur, yas, cinsiyet, agirlik)
        {
            this.buyukluk = buyukluk;
        }
        public override void SesCıkar()
        {
            Console.WriteLine("Fil ses çıkarıyor..." + getTur() + " " + getCinsiyet() + " " + getAgirlik() + " " +buyukluk);
        }
    }
    public class MemeliHayvan
    {
    
        private string tur;
        private int yas;
        private string cinsiyet;
        private double agirlik; 

        public int getYas()
        {
            return yas;
        }
        public void setYas(int yas)
        {
            this.yas = yas;
        }

        public string getTur()
        {
            return tur;
        }
        public void setTur(string tur)
        {
            this.tur = tur;
        }
        public string getCinsiyet()
        {
            return cinsiyet;
        }

        public void setCinsiyet(string cinsiyet)
        {
            this.cinsiyet = cinsiyet;
        }
        public double getAgirlik()
        {
            return agirlik;
        }
        public void setAgirlik(double agirlik)
        {
            this.agirlik = agirlik;
        }
        public virtual void SesCıkar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor");
        }
        public MemeliHayvan(string tur,int yas,string cinsiyet,double agirlik)
        {
            this.tur = tur;
            this.yas = yas;
            this.cinsiyet= cinsiyet;
            this.agirlik = agirlik;
        }

    }
}

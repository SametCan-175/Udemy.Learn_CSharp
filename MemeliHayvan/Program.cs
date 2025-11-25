using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MemeliHayvan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kopekler K1 = new Kopekler("Golden", 3, "dişi", 12.3, "Sarı");
            K1.SesCıkarma();
            Kediler Ke1 = new Kediler("Tekir", 2, "erkek", 4.2, true);
            Ke1.SesCıkarma();
            Yunuslar Y1 = new Yunuslar("Yunus", 1, "dişi", 200, 170);
            Y1.SesCıkarma();
            Filler F1 = new Filler("Afrika", 5, "erkek", 500, 6000);
            F1.SesCıkarma();
            Console.WriteLine();
            
        }
    }
    public class Kopekler:Memeli
    {
        private string renk;
        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }
        public Kopekler(string tur,int yas,string cinsiyet,double agirlik,string renk) : base(tur, yas, cinsiyet, agirlik)
        {
            Tur = tur;
            Yas = yas;
            Cinsiyet = cinsiyet;
            Agirlik = agirlik;
            Renk = renk;

        }
        public override void SesCıkarma()
        {
            Console.WriteLine("Kopek Havlıyor..."+Tur+" "+Yas+" "+Cinsiyet+" "+ Agirlik);
        }
    }
    public class Kediler: Memeli
    {
        private bool evcil;
        public bool Evcil
        {
            get { return evcil; }
            set { evcil = value; }
        }

        public Kediler(string tur, int yas, string cinsiyet, double agirlik,bool evcil) : base(tur, yas, cinsiyet, agirlik)
        {
            Tur = tur;
            Yas = yas;
            Cinsiyet = cinsiyet;
            Agirlik = agirlik;
            Evcil = evcil;
            

        }
        public override void SesCıkarma()
        {
            Console.WriteLine("Kedi Miyavlıyor..." + Tur + " " + Yas + " " + Cinsiyet + " " + Agirlik+" "+evcil);
        }
    }
    public class Yunuslar:Memeli
    {
        private int iq;
        public int IQ
        {
            get { return iq; }
            set {  iq = value; }
        }
        public Yunuslar(string tur, int yas, string cinsiyet, double agirlik, int iq) : base(tur, yas, cinsiyet, agirlik)
        {
            Tur = tur;
            Yas = yas;
            Cinsiyet = cinsiyet;
            Agirlik = agirlik;
            IQ = iq;
        }
        public override void SesCıkarma()
        {
            Console.WriteLine("Yunuslar ses çıkarıyo..." + Tur + " " + Yas + " " + Cinsiyet + " " + Agirlik+" "+iq);
        }
    }
    public class Filler:Memeli
    {
        private int buyukluk;
        public int Buyukluk
        {
            get { return buyukluk; }
            set { buyukluk = value; }
        }
        public Filler(string tur, int yas, string cinsiyet, double agirlik,int Buyukluk) : base(tur, yas, cinsiyet, agirlik)
        {
            Tur = tur;
            Yas = yas;
            Cinsiyet = cinsiyet;
            Agirlik = agirlik;
            buyukluk = Buyukluk;
        }
        public override void SesCıkarma()
        {
            Console.WriteLine("Filler bağırıyor..." + Tur + " " + Yas + " " + Cinsiyet + " " + Agirlik+" "+buyukluk);
        }
    }
    public class Memeli
    {
        private string tur;
        private int yas;
        private string cinsiyet;
        private double agirlik;

        public string Tur
        {
            get { return tur; }
            set { tur = value; }
        }
        public int Yas
        {
            get { return yas; }
            set { yas = value; }
        }
        public string Cinsiyet
        {
            get { return cinsiyet; }
            set {  cinsiyet = value; }
        }
        public double Agirlik
        {
            get { return agirlik; }
            set { agirlik = value; }
        }
        public virtual void SesCıkarma()
        {
            Console.WriteLine("Hayvan ses çıkarıyor");
        }
        

        public Memeli(string tur , int yas, string cinsiyet , double agirlik )
        {

            Tur = tur;
            Yas = yas;
            Cinsiyet = cinsiyet;
            Agirlik = agirlik;
        }

    }

}

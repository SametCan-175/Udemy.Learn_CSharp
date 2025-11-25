using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OtomobilYonetimSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil otomobil = new Otomobil("TOYOTA", "Coralla", 2020, 100, 250,4);
            otomobil.HizlanmaMetot();
            Console.ReadLine();
        }
        
    }
    public class OrtakOzellik
    {
        private string marka;
        private string model;
        private int uretimYili;
        private int motorHacmi;
        private int hizlanma;
        public OrtakOzellik(string marka,string model,int uretimYili,int motorHacmi,int hizlanma)
        {
            this.marka = marka;
            this.model = model;
            this.uretimYili = uretimYili;
            this.motorHacmi = motorHacmi;
            this.hizlanma=hizlanma;
        }
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model { 
            get { return model; }
            set { model = value; }

        }
        public int UretimYili
        {
            get { return uretimYili; }
            set
            {
                uretimYili = value;
            }
        }
        public int MotorHacmi
        {
            get { return motorHacmi; }
            set { motorHacmi = value; }
        }
        public int Hizlanma
        {
            get { return hizlanma; }
            set { hizlanma = value; }

        }

        public virtual void HizlanmaMetot()
        {
            Console.WriteLine("Araç Hızlanıyor...");
        }

    }
    public class Otomobil:OrtakOzellik
    {
        int tekerlekSayisi;
        public Otomobil(string marka, string model,int uretimYili,int motorHacmi,int hizlanma,int tekerlekSayisi):base(marka,model ,uretimYili,motorHacmi,hizlanma)
        {
            this.tekerlekSayisi = tekerlekSayisi;
        }
        public override void HizlanmaMetot()
        {
            Console.WriteLine("Otomobil Hızlanıyor...");
        }

    }
    public class Kamyon:OrtakOzellik
    {
        private int yukKapasitesi;
        public Kamyon(string marka, string model, int uretimYili, int motorHacmi, int hizlanma ,int yukKapasitesi) : base(marka, model, uretimYili, motorHacmi, hizlanma)
        {
            this.yukKapasitesi = yukKapasitesi;
        }
        public override void HizlanmaMetot()
        {
            Console.WriteLine("Kamyon Hızlanıyor..."); ;
        }
    }
    public class Motorsiklet : OrtakOzellik
    {
        int vitesSayisi;
        public Motorsiklet(string marka, string model, int uretimYili, int motorHacmi, int hizlanma, int vitesSayisi) : base(marka, model, uretimYili, motorHacmi, hizlanma)
        {
            this.vitesSayisi = vitesSayisi;
        }
        public override void HizlanmaMetot()
        {
            Console.WriteLine("Motorsiklet Hızlanıyor...");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemePratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arac A1 = new Arac("Toyota","Corolla");
            A1.BilgileriGoruntule("Toyota","Corolla",2020,100000.5,"Dizel","Otomatik");
            A1.FiyatAta(700000.123, 800000.42, 10000.50,790000);
            Console.WriteLine();
        }
    }
    public class Arac
    {
        private string marka;
        private string model;
        private int modelYil;
        private double km;
        private string yakitTipi;
        private string vitesTipi;
        private double alisFiyat;
        private double satisFiyat;
        private double maxIndirimTutari;
        private double fiyat;

        public string Marka { get { return marka; } set { marka = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int ModelYil { get { return modelYil; } set { modelYil = value; } }
        public double Km { get { return km; } set { km = value; } }
        public string YakitTipi { get { return yakitTipi; } set { yakitTipi = value; } }
        public string VitesTipi {  get{ return vitesTipi; } set { vitesTipi = value; } }

        public double AlisFiyat { get { return alisFiyat; } set { alisFiyat = value; } }
        public double SatisFiyat { get { return satisFiyat; } set { satisFiyat = value; } }
        public double MaxIndirimTutari { get { return maxIndirimTutari; } set { maxIndirimTutari = value; } }
        public double Fiyat { get { return fiyat; } set { fiyat = value; } }

        public Arac(string marka, string model)
        {
            Marka = marka;
            Model = model;
        }
        public Arac(string marka, string model, int modelYil)
        {
            Marka = marka;
            Model = model;
            ModelYil = modelYil;
        }
        public Arac(string marka, string model, int modelYil, double km)
        {
            Marka = marka;
            Model = model;
            ModelYil = modelYil;
            Km = km;
        }
        public void BilgileriGoruntule(string marka, string model, int modelYil, double km, string yakitTipi, string vitesTipi)
        {
            Console.WriteLine("Arabanın bilgileri gösteriliyor: " + marka + " " + model + " " + modelYil + " " + km + " " + yakitTipi + " "+ vitesTipi);
        }
        public void FiyatAta(double alisFiyat, double satisFiyat, double maxIndirimTutar,double fiyat)
        {
            
            Console.WriteLine("Arabanın son fiyati " +(fiyat=(satisFiyat-maxIndirimTutar)));
        }

    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsullemee
{
    internal class Musteri
    {
        public Musteri()
        {
            this.id = IDUret();
        }
        // Class >> Field
        public string isim;
        private string soyad;
        int id;
        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public string Soyad
        {
            get
            {
                return this.soyad;
            }
            set
            {
                this.soyad = value;
            }
        }


        private int IDUret()
        {
            Random rnd = new Random();
            return rnd.Next(1000, 9999);
        }



        //class >> property 
        private string emailAdres;
        public string EmailAdres
        {
            //  get; // database veya farklı bir veri kaynağı... class çağıran programcıya detayı gösterdiğimiz kısım...
            //  set; // dış dünyadan alınan datanın içerisinde private olarak saklanan field içerisine değer atandığı kısım...
            get
            {
                return this.emailAdres;
            }
            set
            {
                this.emailAdres = value;
            }
        }
    }
}

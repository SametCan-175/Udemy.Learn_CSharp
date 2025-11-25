using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şirketmaas_hesapla
{
    internal class Calisan
    {
        private string isim;
        private decimal maas;

        public string Isim
        {
            get { return isim; }

            set
            {
                isim = value;
            }

        }

        public decimal Maas
        {
            get { return maas; }

            set
            {
                if (maas > 0)
                {
                    maas = value;
                }
                else
                {
                    maas = 0;
                }


            }


        }
        public Calisan(string isim, decimal maas)
        {
            if (maas > 0)
            {
                Console.WriteLine("Maasiniz 0 dır");
                this.maas = 0;
            }
            else
            {
                this.isim = isim;
                this.maas = maas;
            }

        }

        public virtual decimal HesaplaPrim()
        {
            return Maas * 0.05m;
        }
        public virtual string BilgileriGetir()
        {
            return $"Isim: {Isim},Maas{Maas}TL";

        }
    }
}

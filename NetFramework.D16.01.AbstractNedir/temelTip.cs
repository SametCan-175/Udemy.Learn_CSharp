using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D16._01.AbstractNedir
{
     public abstract class temelTip
     {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temelTip()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;

        }
        public void test()
        {
            Console.WriteLine("Temel sınıf => test");
        }
    }
}

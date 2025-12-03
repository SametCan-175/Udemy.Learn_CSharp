using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D16._01.AbstractNedir
{
    public class musteri: temelTip 
    {
        public int musteriID { get; set; }
        public musteri()
        {
            musteriID = 1;
        }
        public override void testAbstract()
        {
                       Console.WriteLine("musteri  => testAbstract");
        }
    }
}

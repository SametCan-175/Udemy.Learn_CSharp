using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D18._01.EnumNedir
{
    public class sanalDatabase
    {
        ArrayList sanalDB= new ArrayList();
        public musteriReturnValue musteriYeniKayit(musteri m)
        {

            //parametre kontrol

            //kayıt kontrol 


            sanalDB.Add(m);
            return musteriReturnValue.kayitBasarili;
        }
    }
}

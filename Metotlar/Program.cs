using System;,
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
   
    internal class Program
    {
        //private static  void UyelikBilgiler(String isim,String soyisim,int yas)
        //{
        //    Console.WriteLine("İsim:"+isim);
        //    Console.WriteLine("Soyisim:"+soyisim);
        //    Console.WriteLine("Yaş:" + yas);

        //}
        public static String isim = "Ozan";
        
        public static void UyelikBilgiler(String ad)
        {
            Console.WriteLine("Ad:" + ad);
        }
        public static void UyelikBilgiler(String ad,String soyisim)
        {
            Console.WriteLine("Ad:" + ad);
            Console.WriteLine("Soyisim:"+soyisim);
        }
        public static void UyelikBilgiler(String ad,String soyisim,int yas)
        {
            Console.WriteLine("Ad:" + ad);
            Console.WriteLine("Soyisim:" + soyisim);
            Console.WriteLine("Yaş:" + yas);
        }
        static void Main(string[] args)
        {
            //    Console.Write("İsim Giriniz:");
            //    String isim = Console.ReadLine();
            //    Console.Write("Soyisim Giriniz:");
            //    String soyisim=Console.ReadLine();
            //    UyelikBilgiler(isim,soyisim);
            //    Console.ReadLine();

            UyelikBilgiler("Ozan","Kömcü",24); 
            Console.ReadLine(); 


        }
    }
}

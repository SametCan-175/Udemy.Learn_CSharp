using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Udemy.Learn.D08._02.ArrayListOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü");
            Console.WriteLine("1-Değer ekle");
            Console.WriteLine("2-Değer Listele");
            Console.WriteLine("3-Değer Ara");
            Console.WriteLine("4-Değer Düzenle");
            Console.WriteLine("5-Değer Sil");
            Console.WriteLine("6-Uygulama Çıkış");
            string KullaniciGiriş = Console.ReadLine();

            ArrayList Degerlistesi = new ArrayList();

            switch (KullaniciGiriş) 
            {
                case"1":
                    Console.WriteLine("Kullanıcı değer ekle");
                    string DegerEkle= Console.ReadLine();
                    Degerlistesi.Add(KullaniciGiriş);
                    
                    break;
                case"2":
                    
                        break;
                
            }
        }
    }
}

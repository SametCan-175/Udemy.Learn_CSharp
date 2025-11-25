using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.D08._03.HashTableGenelKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();

            #region Yeni Değer ekleme

            H1.Add("Cars", "Araba");
            H1.Add("House", "Ev");

            H1.Add("Cars", "Araba");
            //H1.Add("Cars","Arabalar"); Key değeri benzersiz olmak zorundadır.

            #endregion

            #region Yardımcı Metotlar 
            bool Kontrol1 = H1.Contains("House");
            bool Kontrol2 = H1.Contains("Door");

            bool kontrol3 = H1.ContainsKey("House");
            bool Kontrol4 = H1.ContainsKey("Araba");

            H1["House"] = "Villa";

            H1.Remove("Cars");
            int KoleksiyonIcindekiToplamDeger = H1.Count;
            H1.Clear();//Koleksiyon içindeki tüm datayı temizleriz.


            #endregion



        }
    }
}
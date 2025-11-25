using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework_D08._04.SortedListGenelKullanim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList  sortedL = new SortedList();

            sortedL.Add(100,"Yüz");
            sortedL.Add(90, "Doksan");
            sortedL.Add(1, "Bir");
            sortedL.Add(9000, "Dokuzbin");
            sortedL.Add("A", "B");
        }
    }
}

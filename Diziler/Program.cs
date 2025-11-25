using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] dizi = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            ArrayList diziler= new ArrayList();
            diziler.Add(0);
            diziler.Add(1);
            diziler.Add(2);
            diziler.Add(3);
            diziler.Add(4);
            diziler.Add(5);
            foreach(var s in diziler)
                {
                Console.WriteLine(s);
            }
            
            for(int i=0; i<dizi.Length;i++)
            {
                if (dizi[4]!=5)
                {
                    Console.WriteLine("Bu sayı 5 değildir." + dizi[4]);
                    break;
                }  
            }
            Console.ReadLine();
        }
    }
}

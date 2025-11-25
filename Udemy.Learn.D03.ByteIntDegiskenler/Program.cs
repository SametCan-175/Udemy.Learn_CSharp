using System.Numerics;

namespace Udemy.Learn.D03.ByteIntDegiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Byte ve Int:

            byte yas = 25;// 0 ile 255 arasında olan değerleri bu değişken üzerinden taşıyabilirim.
            int seviye = 1000;

            Console.WriteLine(yas);
            Console.WriteLine(seviye);

            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
        }
    }
}

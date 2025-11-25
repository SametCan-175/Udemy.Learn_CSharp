namespace Udemy.Learn.D03.ConvertParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                     Parse İşlemleri
            string parseVeriI = "45";
            int parseIntI = int.Parse(parseVeriI);

            parseVeriI = "A45";
            parseIntI = int.Parse(parseVeriI);
            bool isok = int.TryParse(parseVeriI, out parseIntI);


            //                    Convert İşlemleri

        }
    }
}

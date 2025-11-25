namespace Udemy.Learn.D03.DateTimeDegiskenInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime HazirlikZamani = DateTime.Now.AddDays(-10);
            DateTime OlusturmaZamani = DateTime.Now;
            DateTime SiparisZamani = DateTime.Now.AddDays(3);
            DateTime GönderimZamani = DateTime.Now.AddDays(10);

            Console.WriteLine(HazirlikZamani);
        }
    }
}

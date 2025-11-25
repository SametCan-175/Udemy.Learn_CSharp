namespace Udemy.Learn.D06._03.ForeachDongusuInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach (var item in collection)  
            //{
            //
            //
            //}

            string[] personeller = { "Hasan", "Mehmet", "Ozkan", "Cengiz" };
            foreach (var item in personeller)
            {
                Console.WriteLine(item);
            }
        }
    }
}

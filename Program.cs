using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public double U(double x)
        {
            return Math.Sqrt(x);
        }

        public double UsefulnessWork1()
        {
            return 0.5 * U(1000) + 0.5 * U(3000);
        }

        public double UsefulnessWork2()
        {
            return U(2000);
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Usefulness of work 1 = {new Program().UsefulnessWork1()}");
            Console.WriteLine($"Usefulness of work 2 = {new Program().UsefulnessWork2()}");

            if(new Program().UsefulnessWork1() > new Program().UsefulnessWork2())
                Console.WriteLine("\nRecommendation to choose the first job!");
            else
                Console.WriteLine("\nRecommendation to choose the second job!");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ameba_task
{
    class Program
    {
        private static void RunSimulationAndPrint(int[] X, int A)
        {
            Console.WriteLine(Simulate(X, A));
            Console.WriteLine();
        }

        private static void Tests()
        {
            RunSimulationAndPrint(new [] { 2, 1, 3, 1, 2 }, 1);
            
            RunSimulationAndPrint(new [] { 1, 4, 9, 16, 25, 36, 49 }, 10);

            RunSimulationAndPrint(new [] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 1024, 2048 }, 1);

            RunSimulationAndPrint(new [] { 817, 832, 817, 832, 126, 817, 63, 63, 126, 817, 832, 287, 823, 817, 574 }, 63);
        }

        private static void RealData()
        {
            RunSimulationAndPrint(new[] { 4, 5, 6, 8, 6, 3, 9, 12, 80, 35, 16, 40, 32, 24, 10, 20, 40, 48 }, 4);
            RunSimulationAndPrint(new[] { 4, 5, 6, 8, 6, 3, 9, 12, 80, 35, 16, 40, 32, 24, 10, 20, 40, 48 }, 5);
            RunSimulationAndPrint(new[] { 4, 5, 6, 8, 6, 3, 9, 12, 80, 35, 16, 40, 32, 24, 10, 20, 40, 48 }, 6);
        }

        static void Main(string[] args)
        {
            //Tests();
            RealData();

            Console.ReadKey();
        }

        static int Simulate(int[] X, int A)
        {
            foreach (int x in X)
            {
                if (A.Equals(x))
                {
                    A *= 2;
                }
            }

            return A;
        }
    }
}

using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1;

            s1 = EquationSolve.SolveEquation(0.1, 1.0, 2.0);
            System.Console.WriteLine("s1 es" + s1);
        }
    }
}

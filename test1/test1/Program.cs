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

            double s2;

            s2 = GeometrySolve.GetVectorLength2(1.0, 1.0);
            System.Console.WriteLine("La longitud del vector en 2D es " + s2);

            double s3;

            s3 = GeometrySolve.GetVectorLength3(1.0, 1.0, 1.0);
            System.Console.WriteLine("La longitud del vector en 3D es " + s3);
        }
    }
}

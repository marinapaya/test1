
namespace test1
{
    class EquationSolve
    {
        public static double SolveEquation(double a, double b, double c)
        {
            double aux, aux2, x;
            aux = b* b - 4.0 * a* c;
            aux2 = System.Math.Sqrt(aux);
            x = (-b + aux2) / (2.0 * a);
            return x;
        }
    }
}

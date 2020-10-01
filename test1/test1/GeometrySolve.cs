using System.IO.Compression;

namespace test1
{
    class GeometrySolve
    {
        public static double GetVectorLength2(double x, double y)
        {
            double aux;
            double length;

            aux = (x * x) + (y * y);
            length = System.Math.Sqrt(aux);
            return length;
        }
        public static double GetVectorLength3(double x, double y, double z)
        {
            double aux;
            double length;

            aux = (x * x) + (y * y) + (z * z);
            length = System.Math.Sqrt(aux);
            return length;
        }
    }
}

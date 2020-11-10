
using System.Security.Cryptography.X509Certificates;

namespace test1
{
    class EJERCICIOSEXAMEN
    {
        //Hacer una funcion a la que se le pasen dos numeros enteros y 
        //devuelva la suma de esos dos numeros enteros

        public static int Ejercicio1(int a, int b)
        {
            int x;
            x = a + b;
            return x;
        }

        //hacer una funcion que reciba dos reales y 
        //devuelva la resta de esos dos reales

        public static double Ejercicio2(double a, double b)
        {
            return a - b;
        }

        //hacer una funcion a la que se le pase dos enteros
        //y devuelva el menor

        public static int Ejercicio3(int a, int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        //hacer una funcion que reciba como parametro dos enteros 
        //y devuelva si el primero es menor que el segundo
        public static bool Ejercicio4(int a, int b)
        {
            if (a < b)
                return true;
            else
                return false;
        }

        //Hacer una funcion a la que se le pasen tres strings y devuelva 
        //la concatenacion de los tres strings
        public static string Ejercicio5(string s1, string s2, string s3)
        {
            return s1 + s2 + s3;
        }

        //Hacer una funcion que reciba dos enteros y devuelva
        //-1 si el primero es menor que el segundo, +1 si el segundo es menor que el primero
        //y 0 en cualquier otro casa (que sean iguales)
        public static int Ejercicio5(int a, int b)
        {
            if (a < b)
                return -1;
            else if (a > b)
                return +1;
            else
                return 0;
        }

        //Hacer una funcion que te devuelva el menor de tres enteros
        public static int Ejercicio6(int a, int b, int c)
        {
            if (a <= b && a <= c)
                return a;
            if (b <= a && b <= c)
                return b;
            return c;
        }

        //Hacer una funcion que reciba un codigo de error e imprima por pantalla
        //lo siguiente: "Error grave" si el codigo de error es 0/ error moderado 
        //si es 1/ Error leve si es 2/ Error desconocido otro caso
        public static void Ejercicio7(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error Grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                  break;
            }
        }

        //Hacer una funcion a la que se le pase un numero e imprima por pantalla
        //una serie como la siguiente: (10) 0,3,6,9/ (15)0,3,6,9,12,15
        public static void Ejercicio8(int n)
        {
            int i = 0;

            while (i <= n)
            {
                System.Console.Write(i + ",");
                i += 3;
            }
        }

        //Hacer una funcion a la que se le pase un numero e imprima por pantalla
        //una serie como la siguiente: (10) 0,1,2,3,4,5,6,7,8,9,/ (3)0,1,2,
        public static void Ejercicio9(int n)
        {
            for(int i = 0; i < n; i++)
                System.Console.Write(i + ",");
        }

        ////Hacer una funcion a la que se le pase un numero e imprima por pantalla
        //una serie como la siguiente: (10) 0,1,2,3,4,5,6,7,8,9/ (3)0,1,2
        public static void Ejercicio10(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1)
                    System.Console.Write(i);
                else
                    System.Console.Write(i + ",");
            }
                
        }

        //Hacer una funcion que reciba un entero e imprima tantos 
        //asteriscos como el valor de ese entero
        public static void Ejercicio11(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }

        //hacer una funcion que imprima por pantalla por ej (5)*+*+*
        public static void Ejercicio12(int n)
        {
            for (int i = 0; i < n; i++)
            { 
                if((i % 2) == 0)
                System.Console.Write("*");
                else
                System.Console.Write("+");
            }
        }
        //Hacer una funcion que devuelva el menor de nueve enteros
        //que la funcion ocupe una sola linea
        public static int Ejercicio13(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9)
        {
            //int menor1 = Ejercicio6(n1, n2, n3);
            //int menor2 = Ejercicio6(n4, n5, n6);
            //int menor3 = Ejercicio6(n7, n8, n9);
            //return Ejercicio6(menor1, menor2, menor3);
            return Ejercicio6(Ejercicio6(n1, n2, n3), Ejercicio6(n4, n5, n6), Ejercicio6(n7, n8, n9));
        }
        //Hacer una funcion a la que se le pase un entero y que imprima 
        //por pantalla el mismo numero de filas y columnas
        public static void Ejercicio14(int n)
        {
            for(int f = 0; f < n; f++)
            {
                for(int c = 0; c < n; c++)
                
                    System.Console.Write("*");

                System.Console.WriteLine();
            }
        }
        //Hacer una funcion a la que se le pase un entero y que imprima 
        //por pantalla el mismo numero de filas y columnas pero una de * y otra de +
        public static void Ejercicio15(int n)
        {
            for(int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((f % 2) == 0)
                        System.Console.Write("*");
                    else
                        System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }
        //Hacer una funcion a la que se le pase un entero y que imprima 
        //por pantalla  filas y columnas
        public static void Ejercicio16(int n)
        {
            for(int f = 0; f < n; f++)
            {
                for (int c = 0; c <= f; c++)
                { 
                    System.Console.Write("*");
                }
                System.Console.WriteLine(); 
            }
        }

        public static void Ejercicio17(int n)
        {
            for(int f = 0; f < n; f++)
            {
                int nespacios = n - f - 1;
                int nasteriscos = f + 1;

                for (int c = 0; c < nespacios ; c++)
                    System.Console.Write(" ");
                for (int c = 0; c < nasteriscos ; c++)
                    System.Console.Write("*");
                System.Console.WriteLine();

            }
        }
        public static void Ejercicio18(int n)
        {
            for(int f = 0; f < n; f++)
            {
                int nespacios1 = n - f - 1;
                int nespacios2 = f * 2;

                for (int c = 0; c < nespacios1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                for (int c = 0; c < nespacios2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                System.Console.WriteLine();
            }
        }

        public static void Ejercicio19(int n)
        {
            for(int f = 0; f < n; f++)
            {
                int nespacios1 = f;
                int nespacios2 = (n - f - 1) * 2;
                for (int c = 0; c < nespacios1; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                for (int c = 0; c < nespacios2; c++)
                    System.Console.Write(" ");
                System.Console.Write("*");
                System.Console.WriteLine();
            }
        }

        public static void Ejercicio20(int n)
        {
            Ejercicio18(n);
            Ejercicio19(n);
        }

        //Hacer una funcion que devuelva 2 elevado a n, siendo
        //n el parametro que recibe la funcion
        public static int Potencia2(int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
                result *= 2;
            return result;
        }
        //Hacer la bandera de estados unidos
        public static void BanderaEEUU()
        {
            for (int f = 0; f < 17; f++)
            {
                for (int c = 0; c < 70; c++)
                {
                    if (0 <= c && c <= 10 && 0 <= f && f <= 10)
                    {
                        int flag = f + c;
                        if ((flag % 2) == 0)
                            System.Console.Write("+");
                        else
                            System.Console.Write(" ");
                    }
                    else if ((f % 4) < 2)
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
               System.Console.WriteLine();
            }
        }
        //hacer una funcion que devuelva la distancia entre dos puntos 2D
        public static double Distance2D(double x1, double y1, double x2, double y2)
        {
            double vx = x2 - x1;
            double vy = y2 - y1;

            return System.Math.Sqrt(vx * vx + vy * vy);
        }

        public static void BanderaJapon()
        {
            for (int f = 0; f < 15; f++)
            {
                for(int c = 0; c < 70; c++)
                {
                    if (f == 0 || f == 14 || c == 0 || c == 69)
                        System.Console.Write("*");
                    else if (Distance2D(35, 7, c, f) <= 3)
                        System.Console.Write(".");
                    else
                        System.Console.Write(" ");
                }
                System.Console.WriteLine();
            }
        }

        //Implementa una funcion que devuelva el sumatorio de un numero
        public static int Sumatorio(int n)
        {
            
            int i;
            int result = 0;
            for (i = 1; i <= n; i++)      
              result += i;
            return result;
        }
    }
}

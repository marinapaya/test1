namespace test1
{
    class Ejercicios
    {
        //Ejercicio: hacer una funcion que imprima por 
        //pantalla los numeros del 0 al 99

        public static void Ejercicio1()
        {
            int contador;
            contador = 0;
            while (contador < 100)
            {
                System.Console.WriteLine(contador);
                contador = contador + 1;
                //contador += 1;
                //contador ++;
            }
        }

        //Ejercicio: Haz una funcion que imprima los 
        //numeros pares que hay desde el 0 hasta n
        public static void Ejercicio2(int n)
        {
            int i;
            i = 0;
            while (i < n)
            {
                if (utils.IsEven(i))
                    System.Console.WriteLine(i);
                i++;
            }
        }

        //Ejercicio 3 primo o no
        public static void Ejercicio3(int numerico)
        {
            bool es_primo = utils.IsPrime(numerico);

            if (es_primo)
                System.Console.WriteLine("El numero " + numerico + " es primo");
            else
                System.Console.WriteLine("El numero " + numerico + " NO es primo");
        }

        //imprimir por pantalla x numeros
        public static void Ejercicio4()
        {
            int i;
            i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(i);
                i++;
            }
        }

        public static void Ejercicio5()
        {
            int i;
            i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(i * 3);
                i++;
            }
        }
        public static void Ejercicio6()
        {
            int i;
            i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(i * i);
                i++;
            }
        }
        public static void Ejercicio7()
        {
            int i;
            i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(i * i + 1);
                i++;
            }
        }

        public static void Ejercicio8()
        {
            int i;
            i = 0;
            while (i <= 100)
            {
                System.Console.WriteLine(5 - i);
                i++;
            }
        }

        public static void Ejercicio9()
        {
            int i = 0;
            while (i <= 100)
            {
                //if(i % 2 == 0)
                if (utils.IsEven(i))
                    System.Console.WriteLine(i);
                else
                    System.Console.WriteLine(-i);
                i++;
            }


        }

        public static void Ejercicio10()
        {
            //esta variable muestra el anteanterior
            int aa = 0;
            int a = 1;
            int i = 0;
            int aux;
            System.Console.WriteLine(aa);
            System.Console.WriteLine(a);

            while (i <= 100)
            {
                System.Console.WriteLine(a + aa);
                aux = a;
                a = aa + a;
                aa = aux;

                i++;
            }


        }

        public static void Ejercicio11( int count)
        {
            int i = 0;
            while (i < count )
            {
                System.Console.Write("*");
                i++;
            }

        }


    }
}

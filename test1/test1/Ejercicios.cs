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

        public static void Ejercicio3(int numerico)
        {
            bool es_primo = utils.IsPrime(numerico);
           
            if (es_primo)
                System.Console.WriteLine("El numero " + numerico + " es primo");
            else
                System.Console.WriteLine("El numero " + numerico + " NO es primo");  
        }

    }
}

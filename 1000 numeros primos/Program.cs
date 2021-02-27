using System;

namespace _1000_numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1, resto, divisor, salirWhile, cantidadNumerosMostrar, contador = 0;

            Console.Write("Cuantos numeros primos mostramos: ");
            cantidadNumerosMostrar = int.Parse(Console.ReadLine());

            
            while (contador < cantidadNumerosMostrar)
            {
                divisor = 2; salirWhile = 0;

                while ((divisor < num) & (salirWhile == 0))
                {

                    resto = num % divisor;

                    if (resto == 0)
                    {
                        salirWhile = 1;
                    }
                    else
                    {
                        divisor = divisor + 1;
                    }
                }

                if (salirWhile == 0)
                {
                    Console.Write(num + " ");
                    contador = contador + 1;
                }

                num = num + 1;
            }

            Console.WriteLine();
        }
    }
}

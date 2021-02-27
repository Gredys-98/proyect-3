using System;

namespace numero_elevado_a_la_potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            double elevadoAlCuadrado = Math.Pow(numero, 2); 
            Console.WriteLine(string.Format("{0} elevado al cuadrado es {1}", numero, elevadoAlCuadrado));
        }
    }
}

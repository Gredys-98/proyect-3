using System;

namespace muestra_las_tablas_del_mutiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string linea;
            Console.Write("Ingrese el numero de la tabla que desea ver: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " x " + n + " = " + i * n + "\n");
            }
            Console.ReadKey();
        }
        
    }
}

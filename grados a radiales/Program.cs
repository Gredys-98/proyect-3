using System;

namespace grados_a_radiales
{
    class Program
    {
        static void Main(string[] args)
        {
            double grados, radiales, pi = 3.1416;
            string valor = "";
            Console.Write("ingrese la cantidad: ");
            valor = Console.ReadLine();
            grados = Convert.ToDouble(valor);
            radiales = gradosradiales(grados, pi);

            Console.WriteLine("{0}º equibalen a {1} radiales ", grados,radiales);

        }
        static double gradosradiales(double n1, double n2)
        {
            double r = 0.0;
            r = (n1 * n2) / 180;
            return r;

        }
    }
}

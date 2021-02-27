using System;

namespace numero_del_1_a_7_y_muestre_que_dia_es
{
    class Program
    {
        static void Main(string[] args)
        {
            string dias;
            Console.WriteLine("ingresa un numero del 1 a 7");
            dias = Console.ReadLine();
            switch (dias)
            {
                case "1": Console.WriteLine("lunes"); break;

                case "2": Console.WriteLine("martes"); break;

                case "3": Console.WriteLine("miercoles"); break;

                case "4": Console.WriteLine("jueves"); break;

                case "5": Console.WriteLine("viernes"); break;

                case "6": Console.WriteLine("sabado"); break;

                case "7": Console.WriteLine(" domingo"); break;

            }
            Console.ReadKey();
        }
    }
}

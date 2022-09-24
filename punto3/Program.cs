using System;
using System.IO;

namespace Punto3
{
    class Program
    {
        static void Main(string [] args)
        {
             Empleado NicolasBilkis = new Empleado();

             Console.WriteLine("La edad es :" + NicolasBilkis.calcula_edad());
             Console.WriteLine("La antiguedad es :" + NicolasBilkis.calcula_antiguadad());
        }
    }
}
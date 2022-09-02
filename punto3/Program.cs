using System;
using System.IO;

namespace Punto3
{
    class Program
    {
        static void Main(string [] args)
        {
             Empleado pepe = new Empleado();

             Console.WriteLine(pepe.calcula_antiguadad());
        }
    }
}
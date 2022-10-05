using System;
using System.IO;

namespace Punto3
{
    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string [] args)
        {
             Empleado NicolasBilkis = new Empleado();
             //Console.WriteLine("La edad es :" + NicolasBilkis.calcula_edad());
             mostrarEmpleados(cargarArreglo());
        }

        static Empleado [] cargarArreglo()
        {
            try
            {
                Console.WriteLine("Ingre el numero de empleados");
                int N = Convert.ToInt32(Console.ReadLine());
                Empleado[] arreglo_empleados = new Empleado[N];

                for (int i = 0; i < arreglo_empleados.Length; i++)
                {
                    arreglo_empleados[i] = new Empleado();

                }

                return arreglo_empleados;
            }
            catch(FormatException e)
            {
                Logger.Info("Error de formato" + e.Message);
                Logger.Debug("Debug",e);
                Logger.Error("Fatal",e);
                throw;
            }
            catch (IOException e)
            {
                Logger.Info("Error de excepcion");
                Console.WriteLine("Error de entrada salida" + e.Message);
                throw;
            }
     
          
        }

        static void mostrarEmpleados(Empleado [] arreglo_empleados)
        {

            try
            {
                for (int i = 0; i < arreglo_empleados.Length; i++)
                {
                    Console.WriteLine("Empleado numero "+  i+1);
                    arreglo_empleados[i].mostrar();

                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                Logger.Error("Error al ingresar un indice q no corresponde");
                Console.WriteLine(e.Message);
                throw;
            }
         
        }
    }
}
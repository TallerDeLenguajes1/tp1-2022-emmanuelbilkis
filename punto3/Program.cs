using System;
using System.IO;

namespace Punto3
{
    class Program
    {
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
                Console.WriteLine("Error de formato" + e.Message);
                throw;
            }
            catch (IOException e)
            {
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
                Console.WriteLine(e.Message);
                throw;
            }
         
        }
    }
}
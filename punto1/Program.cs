using System;
using System.IO;
using System.Text;

namespace punto1
{
    class Program
    {
        static public void Main(string[] args)
        {
            //int numero = cuadrado();
            //cociente();
            kmxlitros();
           
        }

        public static int cuadrado()
        {
            int num;

            try
            {
                 Console.WriteLine("Ingrese un numero entero");
                 num = Convert.ToInt32(Console.ReadLine());
                 num = num*num;
                 Console.WriteLine("El cuadrado es: " + num);
                 
            }
            catch (FormatException e)
            {
                Console.WriteLine("No ingreso el formato correcto, se toma el numero como 0 " + e.Message);
                num=0;
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Ingreso un numero muy grande, se toma el numero como 0 " + e.Message);
                num=0;
            }
            catch(Exception e) // clase padre generica
            { 
                Console.WriteLine("Hay un error al ingresar un numero, se toma el numero como 0" + e.Message);
                num=0;
            }
           

            return num;
        }

        public static void cociente()
        {
           
            try
            {
                Console.WriteLine("Ingrese el numerador");
                int numerador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el denominador");
                int denominador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El resultado es : " + numerador/denominador);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division por cero", e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("No ingreso el formato correcto" + e.Message);
            
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Ingreso un numero muy grande " + e.Message);
            }
             catch(ArgumentNullException e)
            {
                Console.WriteLine("Ingreso un nulo " + e.Message);
            }
            catch(Exception e) // clase padre generica
            { 
                Console.WriteLine("Hay un error al ingresar un numero" + e.Message);
            }
        }

        public static void kmxlitros()
        {
           
            try
            {
                Console.WriteLine("Ingrese los kilometros");
                double numerador = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese los litros usados");
                double denominador = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Km/litros : " + numerador/denominador);
            }
            /*catch (DivideByZeroException e)
            {
                Console.WriteLine("Division por cero", e.Message); // no arroja excepcion cuando el denominador es double
            }*/
            catch (FormatException e)
            {
                Console.WriteLine("No ingreso el formato correcto" + e.Message);
            
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Ingreso un numero muy grande " + e.Message);
            }
            catch(ArgumentNullException e)
            {
                Console.WriteLine("Ingreso un nulo " + e.Message);
            }
            catch(Exception e) // clase padre generica
            { 
                Console.WriteLine("Hay un error al ingresar un numero" + e.Message);
            }
        }


    }
}

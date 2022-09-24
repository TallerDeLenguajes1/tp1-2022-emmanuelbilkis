using System;
using System.IO;

namespace Name
{
    class Program
    {
        static void main()
        {
            FuncionLLamadoraA();

            try
            {
                FuncionLLamadoraB();
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("La funcion b divide en 0" + e.Message);
            }
           

            void FuncionLLamadoraA()
            {
                Dividir(3,3);
            }

            void FuncionLLamadoraB()
            {
                Dividir(3,0);
            }

            void Dividir(int a,int b)
            {
                try
                {
                    int c = a/b;
                }
                catch (System.DivideByZeroException e)
                {
                    Console.WriteLine("Divide en 0" + e.Message);
                }
                catch(System.FormatException e)
                {
                     Console.WriteLine("Error de formato ingresado" + e.Message);
                }
            }
        }

     
    }
}



/*
Escribir la declaración de una clase que almacene información de un empleado: Datos
personales, Dirección, fecha de ingreso la empresa, datos profesionales.*/

namespace Punto3
{
    class Empleado
    {
        private string? nombre;
        private string? apellido;
        private string? documento;
        private string fecha_nacimiento;
        private string? direccion;
        private string fecha_ingreso_empresa;
        private float sueldo_basico;
        private string? puesto_en_la_empresa;


        public Empleado(string? nombre, string? apellido, string? documento, string fecha_nacimiento, string? direccion, string fecha_ingreso_empresa, float sueldo_basico, int antiguedad, string? puesto_en_la_empresa)
        {
            try
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.documento = documento;
                this.fecha_nacimiento = fecha_nacimiento;
                this.direccion = direccion;
                this.fecha_ingreso_empresa = fecha_ingreso_empresa;
                this.sueldo_basico = sueldo_basico;
                this.puesto_en_la_empresa = puesto_en_la_empresa;
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Ingreso un formato incorrecto" + e.Message + e.HelpLink);
                throw;
            }

        } // constructor sobrecargado

        public Empleado(){
            this.nombre = "Nicolás";
            this.apellido = "Bilkis";
            this.documento = "36998256";
            this.fecha_nacimiento = "treinta de septiembre de 1992";
            this.direccion = "San Juan 200";
            this.fecha_ingreso_empresa = "18-04-2015";
            this.sueldo_basico = 105234;
            this.puesto_en_la_empresa = "Jefe de produccion";

        } // constructor por defecto

      
        public int calcula_antiguadad()
        {
 
            try
            {
                int antiguedad;
                DateTime fecha_actual = DateTime.Now;
                DateTime fecha_ingreso_date = DateTime.ParseExact(this.fecha_ingreso_empresa,"dd/MM/yyyy", null);    
                antiguedad = (fecha_actual.Year - fecha_ingreso_date.Year);
                return antiguedad;
            }
            catch (System.FormatException e)
            {
                Console.WriteLine ("El formato de fecha ingresado no es el correspondiente" + e.Message);
                throw;
            }
            catch(System.NullReferenceException e)
            {
                Console.WriteLine ("no corresponde un Null" + e.Message);
                throw;
            }
        }

        public int calcula_edad()
        {
            try
            {
                int edad;
                DateTime fecha_actual = DateTime.Now;
                DateTime fecha_nac_date = DateTime.ParseExact(this.fecha_nacimiento,"dd/MM/yyyy", null);
                edad = (fecha_actual.Year - fecha_nac_date.Year);
                return edad;    
            }
            catch (System.FormatException e)
            {
                Console.WriteLine ("El formato de fecha ingresado y/o calculado no es el correspondiente" + e.Message);
                throw;
            }
            catch(System.NullReferenceException e)
            {
                Console.WriteLine ("no corresponde un Null" + e.Message);
                throw;
            }
            
        }

        public double calcula_salario()
        {
            try
            {
                double salario = 0;
                double adicional = this.sueldo_basico*(calcula_antiguadad()/100);
                double descuento = 0.15 * this.sueldo_basico;
                salario = sueldo_basico + adicional - descuento;
                return salario;
            }
            catch(System.FormatException e)
            {
                Console.WriteLine("Formato incorrecto" + e.Message);
                throw;
            }
            catch (System.ArithmeticException e)
            {
                Console.WriteLine("Error aritmetico" + e.Message);
                throw;
            }
            catch(System.NullReferenceException e)
            {
                Console.WriteLine("Null no correspondiente" + e.HelpLink + e.Message);
                throw;
            }
        
        }
    }
}
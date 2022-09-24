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
        bool esCasado;
        int cantidad_hijos;
        bool divorciado;
        string fecha_divorcio;
        bool titulo_universitario;
        string titulo_obtenido;
        string universidad;




        public Empleado(string? nombre, string? apellido, string? documento, string fecha_nacimiento, string? direccion, string fecha_ingreso_empresa, float sueldo_basico, int antiguedad, string? puesto_en_la_empresa, bool esCasado,int cantidad_hijos,bool divorciado,string fecha_divorcio,bool titulo_universitario,string titulo_obtenido,  string universidad)
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
                this.esCasado = esCasado;
                this.divorciado = divorciado;
                this.cantidad_hijos = cantidad_hijos;
                this.fecha_divorcio = fecha_divorcio;
                this.titulo_universitario = titulo_universitario;
                this.titulo_obtenido = titulo_obtenido;
                this.universidad = universidad;
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
            this.fecha_nacimiento = "30/09/1992";
            this.direccion = "San Juan 200";
            this.fecha_ingreso_empresa = "30/09/2015";
            this.sueldo_basico = 105234;
            this.puesto_en_la_empresa = "Jefe de produccion";
            this.esCasado = true;
            this.cantidad_hijos = 3;
            this.divorciado = false;
            this.fecha_divorcio = "null";
            this.titulo_universitario = true;
            this.titulo_obtenido = "Programador Universitario";
            this.universidad = "Facultad de Ciencias Exactas UNT";

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

        public void mostrar(){

                Console.WriteLine("Nombre y apellido: " + this.nombre + this.apellido);
                Console.WriteLine ("Edad : " + this.calcula_edad());
                Console.WriteLine("Antiguedad: " +  this.calcula_antiguadad()); 
        }
    }
}
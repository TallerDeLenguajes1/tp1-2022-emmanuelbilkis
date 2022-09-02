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
        private DateTime fecha_nacimiento;
        private string? direccion;
        private DateTime fecha_ingreso_empresa;
        private double sueldo_basico;
        private int antiguedad;
        private string? puesto_en_la_empresa;

        public Empleado()
        {
            nombre = "Pepe";
            apellido = "Garcia";
            documento = "32456767";
            DateTime fecha_nacimiento = new DateTime(1989, 11, 2, 11, 15, 16);
            direccion = "Pasaje lucierngas 546";
            sueldo_basico = 150000;
            puesto_en_la_empresa = "Empleado administrativo";
             DateTime fecha_ingreso_empresa = new DateTime(2010, 12, 5, 11, 15, 16);
        }

        public Empleado(string? nombre, string? apellido, string? documento, DateTime fecha_nacimiento, string? direccion, DateTime fecha_ingreso_empresa, double sueldo_basico, int antiguedad, string? puesto_en_la_empresa)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
            this.fecha_nacimiento = fecha_nacimiento;
            this.direccion = direccion;
            this.fecha_ingreso_empresa = fecha_ingreso_empresa;
            this.sueldo_basico = sueldo_basico;
            this.antiguedad = antiguedad;
            this.puesto_en_la_empresa = puesto_en_la_empresa;
        }

      
        public int calcula_antiguadad()
        {
            int antiguedad;
            DateTime fecha_actual = DateTime.Now;
            antiguedad = Convert.ToInt16(fecha_actual - fecha_nacimiento);
            return antiguedad;
         
        }

        public int calcula_edad()
        {
            int edad;
            DateTime fecha_actual = DateTime.Now;
            edad = Convert.ToInt16(fecha_actual - fecha_nacimiento);
            return edad;
        }

        public double calcula_salario()
        {
            double salario;
            double adicional = sueldo_basico*(calcula_antiguadad()/100);
            double descuento = 0.15 * sueldo_basico;

            salario = sueldo_basico + adicional - descuento;

            return salario;
        }
    }
}
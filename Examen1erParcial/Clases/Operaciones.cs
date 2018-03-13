using System;
namespace Examen1erParcial.Clases
{
    public class Operaciones
    {

        public double num1
        {
            get;
            set;
        }

        public double num2
        {
            get;
            set;
        }
    
        public int TipoOperacion
        {
            get;
            set;
        }
    
        public Operaciones()
        {

        }

        public Operaciones(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Suma (double num1, double num2)
        {
            return num1 + num2;
        }

        public double Resta(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}

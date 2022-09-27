using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Euro()
        {
            Euro.cotizRespectoDolar = 1/1.18;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public double getCantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public static double getCotizacion
        {
            get
            {
                return Euro.cotizRespectoDolar;
            }
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d); 
        }


        public static implicit operator Dolar(Euro e)
        {
            return new Euro((e.cantidad * Euro.getCotizacion));
        }

        public static implicit operator Peso(Euro e)
        {
            return  (Peso)((Dolar)e);
        }




    }
}

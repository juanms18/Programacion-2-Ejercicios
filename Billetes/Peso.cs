using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        static Peso()
        {
            Peso.cotizRespectoDolar = 180;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotizRespectoDolar = cotizacion;
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
                return Peso.cotizRespectoDolar;
            }
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.getCantidad / Peso.getCotizacion));
        }

        public static explicit operator Euro(Peso p)
        {   
            return (Euro)((Dolar)p);
        }

    }

}

    
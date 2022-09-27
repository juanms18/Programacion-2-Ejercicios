namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;


        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;  
        }

        public Dolar (double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
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
                return Dolar.cotizRespectoDolar;
            }
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static explicit operator Euro (Dolar d)
        {
            return new Euro((d.cantidad * Euro.getCotizacion));
        }

        public static explicit operator Peso (Dolar d)
        {
            return new Peso((d.cantidad * Euro.getCotizacion));
        }


        
        
    }
}
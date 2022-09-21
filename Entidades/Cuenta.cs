using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;
        public static int ContadorDeCuentas;

        static Cuenta()
        {
            Cuenta.ContadorDeCuentas = 0;
        }

        public Cuenta()
        {
            ContadorDeCuentas++;
            this.titular = "vacio";
            this.cantidad = 0;
        }

        public Cuenta(string titular, decimal cantidad)
        {
            ContadorDeCuentas++;
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular()
        {
            return this.titular;
        }

        public decimal Cantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos de la cuenta:");
            sb.AppendLine($"Titular: {this.titular}");
            sb.AppendLine($"Cantidad: {this.cantidad}");

            return sb.ToString();
        }

        public bool Ingresar(decimal cantidad)
        {
            bool retorno = false;
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
                retorno = true;
            }
            return retorno;
        }

        public bool Retirar(decimal cantidad)
        {
            bool retorno = false;
            if (cantidad > 0)
            {
                this.cantidad -= cantidad;
                retorno = true;
            }
            return retorno;
        }

    }
}
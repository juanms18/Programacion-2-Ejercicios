
using Entidades;
namespace Clase_3_Ej_1
{
     class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("123SA", 1000);
            Cuenta cuenta2 = new Cuenta();
           


            //Console.WriteLine($"Datos de la cuenta por defecto:\nTitular: {cuenta1.Titular()}\nMonto: {cuenta1.Cantidad()}");
            //Console.WriteLine("");

            //Console.WriteLine("Ingreso 21.99 pesos: ");
            //cuenta1.Ingresar(21.99M);
            //Console.WriteLine($"Datos de la cuenta luego de ingresar dinero:\nTitular: {cuenta1.Titular()}\nMonto: {cuenta1.Cantidad()}");
            //Console.WriteLine("");

            //Console.WriteLine($"voy a mostrar probando \n{cuenta1.Mostrar()}");

            //Console.WriteLine("Retiro 800 pesos: ");
            //cuenta1.Retirar(800);
            //Console.WriteLine($"Datos de la cuenta luego de retirar dinero:\nTitular: {cuenta1.Titular()}\nMonto: {cuenta1.Cantidad()}");
            //Console.WriteLine("");

            //Console.WriteLine("Retiro 600 pesos: ");
            //cuenta1.Retirar(800);
            //Console.WriteLine($"Datos de la cuenta luego de retirar dinero:\nTitular: {cuenta1.Titular()}\nMonto: {cuenta1.Cantidad()}");


            Console.WriteLine("La cantida de cuentas es: {0}", Cuenta.ContadorDeCuentas) ;
        }
    }
}
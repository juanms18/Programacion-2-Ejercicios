using Clase2_ej_1;

namespace Clase2_ej_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;
            string respuesta;
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numero = int.Parse (Console.ReadLine());
                suma += numero;
                Console.WriteLine("si desea continar presione la S");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine("La suma de los numeros ingresados es {0}",suma);
            
        }
    }
}
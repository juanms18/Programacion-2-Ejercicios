namespace clase1_ej_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Ingrese un numero!");
            numero = double.Parse(Console.ReadLine());

            while (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.WriteLine("Ingrese un numero!");
                numero = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("El cuadrado del numero es {0} y el cubo es {1}",Math.Pow(numero , 2) , Math.Pow(numero , 3  ));


        }
    }
}
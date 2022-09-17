namespace Clase2_ej_5
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej 5";
            Console.WriteLine("Area de un cuadrado de lado 5:" + CalculoDeArea.CalculoCuadrado(5));
            Console.WriteLine("Area de un triangulo de base  2  y altura 3 :" + CalculoDeArea.CalculoTriangulo(2,3));
            Console.WriteLine("Area de un circulo de radio 3:  " + CalculoDeArea.CalculoCirculo(3));
            Console.ReadKey();
        }
    }
}
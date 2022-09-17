namespace Clase_1_ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lineas;
            int i;
            int j;
            Console.WriteLine("Ingrese la cantidad de filas del triangulo:");
            lineas = int.Parse(Console.ReadLine());
            for (i = 0; i < lineas+1; i++)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
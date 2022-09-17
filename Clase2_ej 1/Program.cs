using Clase2_ej_3;
namespace Clase2_ej_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ej 1";
            float minimo = 0;
            float maximo = 0;
            float numero;
            float promedio = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = float.Parse(Console.ReadLine());
                if (Validador.Validar(numero, -100, 100, "Error Valor fuera de rango") == true)
                {
                    
                    if (i == 0)
                    {
                        maximo = numero;
                        minimo = numero;
                    }
                    else
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }
                        if (numero > maximo)
                        {
                            maximo = numero;
                        }
                    }
                    promedio += numero;
                }
                else
                {
                    i--;
                }

            }
            Console.WriteLine("El maximo es :{0}", maximo);
            Console.WriteLine("El minimo es :{0}", minimo);
            Console.WriteLine("El promedio es :{0}", promedio / 5);
            Console.ReadKey();
           


        }
    }
}
    
   
       
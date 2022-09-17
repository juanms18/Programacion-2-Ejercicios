namespace ej_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float minimo=0;
            float maximo=0;
            float numero;
            float promedio = 0 ;

            for (int i = 0; i < 5; ++i)
            {
                Console.Write("Ingrese un numero: ");
                numero = float.Parse(Console.ReadLine());
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
            Console.WriteLine("El maximo es :{0}", maximo);
            Console.WriteLine("El minimo es :{0}", minimo);
            Console.WriteLine("El promedio es :{0}", promedio/5);


        }
    }
}
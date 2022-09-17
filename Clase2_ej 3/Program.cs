namespace Clase2_ej_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero decimal");
            int numero = int.Parse(Console.ReadLine());

            long binario = Conversor.ConvertirDecimalABinario(numero);
            Console.WriteLine("El numero decimal " + numero + " en binario es " + binario);

            Console.WriteLine("Escribe un numero binario");
            long numeroBinario = long.Parse(Console.ReadLine());

            int decimalB = Conversor.ConvertirBinarioADecimal(numeroBinario);
            Console.WriteLine("El numero binario " + binario + " en decimal es " + decimalB);
            
            
            Console.ReadLine();
        }
    }
}
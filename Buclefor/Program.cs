namespace Buclefor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPRIMIR LOS PRIMEROS 10 NUMEROS EN PANTALLA");
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Numero - " + i);
            }
            Console.WriteLine("a finalizado el bucle");
        }

    }
}
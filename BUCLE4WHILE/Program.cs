namespace BUCLE4WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("DETERMINAR SI UN NUMERO ES POSITIVO");
            Console.WriteLine();

            int numero;

            Console.WriteLine("introdica un numero");
            numero = int.Parse(Console.ReadLine());

            do 
            {

                Console.WriteLine("introdica un numero");
                numero = int.Parse(Console.ReadLine());
            }
            while(numero > 0);
            Console.WriteLine("Ha introducido un numero negativo");
        }
    }
}

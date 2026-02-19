namespace Tarea_2_Promedio
{
    internal class Program
    {
        // Función que calcula el promedio
        static double CalcularPromedio(double n1, double n2, double n3, double n4)
        {
            double promedio;
            promedio = (n1 + n2 + n3 + n4) / 4;
            return promedio;
        }

        static void Main(string[] args)
        {
            double n1, n2, n3, n4, promedio;

            Console.Write("Escribe la primera calificación: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe la segunda calificación: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe la tercera calificación: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe la cuarta calificación: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            // Llamar a la función
            promedio = CalcularPromedio(n1, n2, n3, n4);

            // Mostrar el promedio
            Console.WriteLine("\nEl promedio es: " + promedio);

            // Condición para aprobar o reprobar
            if (promedio >= 70)
            {
                Console.WriteLine("¡Aprobado!");
            }
            else
            {
                Console.WriteLine("Reprobado.");
            }

           
        }
    }
}

namespace Tarea_3_menu_de_opciones
{
    internal class Program
    {
          
        // Procedimiento para mostrar el menú
        static void Menu()
        {
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
        }

        // Funciones para las operaciones
        static double Sumar(double D1, double D2)
        {
            return D1 + D2;
        }

        static double Restar(double D1, double D2)
        {
            return D1 - D2;
        }

        static double Multiplicar(double D1, double D2)
        {
            return D1 * D2;
        }

        static double Dividir(double D1, double D2)
        {
            return D1 / D2;
        }

        static void Main(string[] args)
        {
            double D1, D2, resultado;
            int opcion;

            // aqui  llamar el procedimiento

            Menu(); 

            Console.Write("\nElige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe el primer número (D1): ");
            D1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe el segundo número (D2): ");
            D2 = Convert.ToDouble(Console.ReadLine());

            if (opcion == 1)
                resultado = Sumar(D1, D2);
            else if (opcion == 2)
                resultado = Restar(D1, D2);
            else if (opcion == 3)
                resultado = Multiplicar(D1, D2);
            else
                resultado = Dividir(D1, D2);

            Console.WriteLine("\nEl resultado es: " + resultado);
        }
    }
}

namespace Tarea1_Laboratorio_I
{
    internal class Program
    {
        static void MostrarNombre()
        {
            Console.Write("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
          

            Console.WriteLine("Que se mueve  " + nombre + ", bienvenido al laboratorio ");

          
        }

        // Función: calcula el área de un rectángulo
        static double CalcularArea()
        {
            // declaracion de variables 
            double baseRect, altura, area; 

            Console.Write("Escribe la base del rectángulo: ");
            baseRect = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe la altura del rectángulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = baseRect * altura;

            return area;
        }

        static void Main(string[] args)
        {
            // Llamamos al procedimiento
            MostrarNombre();

            // Llamamos a la función y guardamos el resultado
            double resultado = CalcularArea();

            // Mostramos el área en pantalla
            Console.WriteLine("El área del rectángulo es: " + resultado);

           

        }
    }
}

namespace Laboratorio_1
{
    internal class Program
    {
         // Procedimiento: no devuelve nada, solo muestra un mensaje
        static void MostrarNombre()
        {
            Console.Write("Escribe tu nombre: ");
            string nombre = Console.ReadLine();
            
            // Leer el nombre del usuario
            Console.WriteLine("Hola " + nombre + ", bienvenido al laboratorio activate falton ");
        }

        // Función: pide base y altura y devuelve el área del rectángulo
        static double CalcularArea()
        {
            Console.Write("Escribe la base del rectángulo: ");
            double baseRect = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escribe la altura del rectángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = baseRect * altura;
            return area; // devuelve el resultado
        }

        static void Main(string[] args)
        {
            // Llamamos al procedimiento
            MostrarNombre();

            // Llamamos a la función y guardamos el valor que retorna
            double resultado = CalcularArea();

            // Mostramos el resultado en pantalla
            Console.WriteLine("El área del rectángulo es: " + resultado);

            
        }
    }
}

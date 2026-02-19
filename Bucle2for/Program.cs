namespace Bucle2for
{
    internal class Program
    {
        private static string i;
        static void Main(string[] args)
        {
            Console.WriteLine("Gestion De Empleado ");
            Console.WriteLine();

            int numero_de_emplados;
            double sueldo, promedio, suma_sueldo=0 ;

            Console.WriteLine("ingrese la cantidad de empleados ");
            numero_de_emplados =int.Parse(Console.ReadLine());

            for (int i = 1; i <=numero_de_emplados; i++)
            {
                Console.WriteLine("DIGITE EL SUELDO DEL EMPLEADO" + i);
                sueldo=double.Parse(Console.ReadLine());
                suma_sueldo += sueldo;

            }
            promedio = suma_sueldo /numero_de_emplados ;

            Console.WriteLine("El sueldo promedio de un empleado es :"+ promedio);



        }
    }
}

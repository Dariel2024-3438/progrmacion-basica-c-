namespace juan_perez_tarea_1_calculo_ISR_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CÁLCULO DEL ISR DE UN EMPLEADO (Impuesto Sobre la Renta)");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Ingrese su salario mensual: ");
            double salarioMensual = Convert.ToDouble(Console.ReadLine());


            // variables para el cálculo del ISR
            double salarioAnual = salarioMensual * 12;
            double irsAnual = 0;
            double irsMensual = 0;

            // Condiciones para determinar el ISR anual según los tramos establecidos por la DGII (2026)
            if (salarioAnual <= 416220)
            {
                Console.WriteLine("Sueldo: " + salarioMensual);
                Console.WriteLine("ISR: N/A )");
            }
            else if (salarioAnual <= 624329)
            {
                irsAnual = (salarioAnual - 416220) * 0.15;
            }
            else if (salarioAnual <= 867123)
            {
                irsAnual = 31216 + (salarioAnual - 624329) * 0.20;
            }
            else
            {
                irsAnual = 79776 + (salarioAnual - 867123) * 0.25;
            }

            if (irsAnual > 0)
            {
                irsMensual = irsAnual / 12;
                Console.WriteLine("Sueldo: " + salarioMensual);
                Console.WriteLine("ISR mensual: " + irsMensual);
            }

            // algo que agrege pos confucion pos si las moscas ahaahah

            Console.WriteLine("-----------------------------------------");
            if (irsAnual > 0)
            {
                Console.WriteLine("Total a pagar de ISR ANUAL: " + irsAnual);
                Console.WriteLine("Total a pagar de ISR MENSUAL: " + irsMensual);
            }
            else
            {
                Console.WriteLine("Total a pagar de ISR ANUAL: N/A");
                Console.WriteLine("Total a pagar de ISR MENSUAL: N/A");
            }





            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Cálculo realizado según DGII (2026)");
            Console.ReadKey();



        }
    }
}

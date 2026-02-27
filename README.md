# Cálculo del ISR (Impuesto Sobre la Renta)

Asignatura: Programación Básica  
Profesor: Gamalier Reyes del Carmen  
Estudiante: Dariel Ramos de la cruz 2024-3438 
Año: 2026  


Descripción
Este programa en **C#** calcula el **ISR (Impuesto Sobre la Renta)** de un empleado en la **República Dominicana**, según la escala oficial de la DGII vigente al año 2026.  
El usuario introduce su **salario mensual**, y el programa determina:
- El **ISR mensual** a pagar.  
- El **ISR anual** total.  
- Si el empleado está **exento**, muestra “N/A”.  

---

## ⚙️ Escala DGII (2026)
| Rango salarial anual (RD$) | Tasa ISR |
|----------------------------:|:----------:|
| Hasta 416,220.00            | Exento |
| 416,220.01 – 624,329.00     | 15% del excedente |
| 624,329.01 – 867,123.00     | 31,216 + 20% del excedente |
| Más de 867,123.01           | 79,776 + 25% del excedente |

---

💻 Ejecución del programa
(capturas):
<img width="903" height="540" alt="{59F9B68C-C93F-4E97-93BD-8B3969262885}" src="https://github.com/user-attachments/assets/eb51ffc9-fcc3-42aa-9509-d78d87fe6d66" />
<img width="902" height="540" alt="{E2CE064A-D63C-4F17-A177-C04FE76C6F56}" src="https://github.com/user-attachments/assets/c70fa6f1-703a-4be3-8d13-b4517b5a3d9a" />

codigo :

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


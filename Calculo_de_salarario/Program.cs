// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo de salario");
Console.WriteLine(".....................");

double PagoPorHoras ,HorasTrabajadas ,AFP, SFS, SueldoBruto, SueldoNeto;

//poceso

Console.WriteLine("Ingrese el pago por horas: ");
PagoPorHoras = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese Las Horas trabajadas : ");
HorasTrabajadas = double.Parse(Console.ReadLine());

SueldoBruto = PagoPorHoras * HorasTrabajadas;

AFP = SueldoBruto * 0.287;

SFS = SueldoBruto * 0.0304;

double D;

D = AFP + SFS;

SueldoNeto = SueldoBruto - D;

Console.WriteLine("SueldoBruto:" + SueldoBruto);
Console.WriteLine(".....................");
Console.WriteLine("AFP:" + AFP);
Console.WriteLine(".....................");
Console.WriteLine("SFS:"+SFS);
Console.WriteLine(".....................");
Console.WriteLine("SueldoNeto:"+SueldoNeto);

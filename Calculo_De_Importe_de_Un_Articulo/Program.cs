// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo de importe de un articulo");
Console.WriteLine("..................................");
//variables
double cantidad, precio, importe,ITBIS,Importe_final;

Console.WriteLine("ingresar cantidad del articulo :");
cantidad=double.Parse(Console.ReadLine());
Console.WriteLine("..................................");
Console.WriteLine("ingresar precio del articulo :");
precio = double.Parse(Console.ReadLine());
Console.WriteLine("..................................");
//proceso

importe = cantidad * precio;
ITBIS = importe * 0.18;
Importe_final = importe+ITBIS;

Console.WriteLine("El Importe Es:" + importe);
Console.WriteLine("El ITBIS Es:" + ITBIS);
Console.WriteLine("El Importe Final Es:" + Importe_final);

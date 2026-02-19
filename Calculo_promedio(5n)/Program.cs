// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo_De_Promedio");
Console.WriteLine("...................");

//declaracion de variables 
double n1,n2,n3,n4,n5,d,promedio;

Console.WriteLine("ingresar primera cantidad");
n1 =double.Parse(Console.ReadLine());

Console.WriteLine("ingresar segunda cantidad");
n2 = double.Parse(Console.ReadLine());

Console.WriteLine("ingresar tercera cantidad");
n3 = double.Parse(Console.ReadLine());

Console.WriteLine("ingresar cuarta cantidad");
n4 = double.Parse(Console.ReadLine());

Console.WriteLine("ingresar quinta cantidad");
n5 = double.Parse(Console.ReadLine());



//PROCESO
d =n1+n2 + n3 + n4 + n5;
promedio = d / 5;

Console.WriteLine("El Promedio Es:" + promedio);
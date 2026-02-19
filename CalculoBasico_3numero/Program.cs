// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo Basico");
Console.WriteLine("..............");

//declaracion de variables
double n1,n2,n3,resta,suma,multiplica,divide;

//entrada de datos 
Console.WriteLine("ingrese primera cantidad:");
n1=double.Parse(Console.ReadLine());
Console.WriteLine("ingrese segunda cantidad:");
n2 = double.Parse(Console.ReadLine());
Console.WriteLine("ingrese tecer digito:");
n3 = double.Parse(Console.ReadLine());

//procceso
suma = n1 + n2 + n3;
resta = n1 -n2 - n3;
multiplica=n1 * n2 * n3;
divide = n1/n2/n3;

//salida de informaion
Console.WriteLine("El resultado de la suma es: " + suma);
Console.WriteLine("El resultado de la resta es: " + resta);
Console.WriteLine("El resultado de la multiplicacion es: " + multiplica);
Console.WriteLine("El resultado de la divicion es:  " + divide);
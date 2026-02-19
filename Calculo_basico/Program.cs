// See https://aka.ms/new-console-template for more information
Console.WriteLine("Calculo Basico");
Console.WriteLine("................");


//Declaracion de variable
double n1, n2, suma, resta, multiplica, divide;

//Entrada de Datos
Console.Write("Valo 1:");
n1 = double.Parse(Console.ReadLine());
Console.Write("Valo 2:");
n2 = Convert.ToDouble(Console.ReadLine());

//Proceso
suma = n1 + n2;
resta = n1 - n2;
multiplica = n1 * n2;
divide = n1 / n2;

//salida de la informacion 
Console.WriteLine("El resultado de la suma es: " + suma);
Console.WriteLine("El resultado de la resta es: " + resta);
Console.WriteLine("El resultado de la multiplicacion es: "+ multiplica );
Console.WriteLine("El resultado de la divicion es:  "+ divide);
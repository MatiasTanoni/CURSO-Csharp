//Escriba un programa C# que solicite un número (x)
//y responda si es positivo o negativo.

//Console.WriteLine("Ingrese un numero: ");
//int x = int.Parse(Console.ReadLine());

//if (x > 0)
//{
//    Console.WriteLine("El numero es positivo: " + x);
//}
//else if (x < 0)
//{
//    Console.Write("El numero es negativo" + x);
//}
//else
//{
//    Console.WriteLine("El numero es 0"+ x);
//}

//Cree un programa en C# que solicite un número (x) 
//y muestre 10*x. Debe repetirse hasta que el usuario ingrese 0.

//Console.WriteLine("Ingrese un numero: ");
//int x = int.Parse(Console.ReadLine());

//while (x != 0)
//{   

//    int resultado = x * 10;
//    Console.WriteLine(resultado);

//    Console.WriteLine("Ingrese un numero: ");
//    x = int.Parse(Console.ReadLine());
//}

//Cree un programa en C# que solicite un número (x) y muestre 10*x. 
//Debe repetirse hasta que el usuario ingrese 0.

//Console.WriteLine("Ingrese un numero");
//int x = int.Parse(Console.ReadLine());

//do
//{
//    int resultado = x * 10;
//    Console.WriteLine(resultado);

//    Console.WriteLine("Ingrese un numero");
//    x = int.Parse(Console.ReadLine());
//}
//while (x!=0);
//Console.WriteLine("Es cero");

//Escriba un programa en C# que solicite tres números (x, y, z) y muestre el mayor de ellos.

Console.WriteLine("Ingresa tres numeros");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

if (x > y & x > z)
{
    Console.WriteLine("El numero mas grande es: "+ x);
}
else if (y > x &  y> z)
{ 
    Console.WriteLine("El numero mas grande es: " + y); 
}
else
{
    Console.WriteLine("El numero mas grande es: " + z);
}

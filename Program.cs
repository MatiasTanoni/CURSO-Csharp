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

//Console.WriteLine("Ingresa tres numeros");
//int x = int.Parse(Console.ReadLine());
//int y = int.Parse(Console.ReadLine());
//int z = int.Parse(Console.ReadLine());

//if (x > y & x > z)
//{
//    Console.WriteLine("El numero mas grande es: "+ x);
//}
//else if (y > x &  y> z)
//{ 
//    Console.WriteLine("El numero mas grande es: " + y); 
//}
//else
//{
//    Console.WriteLine("El numero mas grande es: " + z);
//}

//Cree un programa en C# que solicite un rango de números al usuario (x, y)
//y los muestre en pantalla.

//Console.WriteLine("Ingrese un numero");
//int PrimerNumero = int.Parse(Console.ReadLine());
//Console.WriteLine("Ingrese un numero");
//int SegundoNumero = int.Parse(Console.ReadLine());

//if (PrimerNumero < SegundoNumero)
//{
//    for (int i = PrimerNumero; i <= SegundoNumero; i++)
//    {
//        Console.WriteLine(i);
//    }
//}
//else if (SegundoNumero < PrimerNumero)
//{
//    for(int i = SegundoNumero;i <= PrimerNumero;i++)
//    {
//        Console.WriteLine(i);
//    }
//}

//Escriba un programa en C# que solicite números y muestre su suma.
//Solicite números hasta que el usuario ingrese 0 y cuando el programa
//termine muestre Terminado.

//int numero;
//int resultado = 0;
//do
//{
//    Console.WriteLine("Ingresa un numero");
//    numero = int.Parse(Console.ReadLine());
//    resultado += numero;
//    Console.WriteLine(resultado);
//}
//while (numero != 0);
//Console.WriteLine("es cero");

//Escriba un programa en C# que solicite un número (x) y una cantidad (y).
//Muestre ese número tantas veces como la cantidad (y).

//Console.WriteLine("Ingrese un numero");
//int numero = int.Parse((Console.ReadLine()));
//Console.WriteLine("Ingrese la cantidad");
//int cantidad  = int.Parse((Console.ReadLine()));

//for  (int i = 0; i < cantidad; i++)
//{
//    Console.WriteLine(numero);
//}

//Cree un programa en C# para mostrar los números impares de x hasta y en orden descendente.

Console.WriteLine("Ingrese un numero");
int PrimerNumero = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un numero");
int SegundoNumero = int.Parse(Console.ReadLine());

while (PrimerNumero >= SegundoNumero)
{ 
    if (PrimerNumero %2 !=0)
    {
        Console.WriteLine(PrimerNumero);
    }
    PrimerNumero--;
}
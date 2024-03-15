//PARA COMENTAR = Ctrl + K + C PARA DESCOMENTAR Ctrl + K + U

///// CLASES #1,2 y 3 Variables /////

//Console.WriteLine("Hello, World!" + "\n" + "Soy Mati");
//Console.WriteLine("Welcome...");

//int primerNumero = 4;
//int segundoNumero = 5;
//int suma;

//suma = primerNumero + segundoNumero;

//Console.WriteLine("La suma de los numeros es: " + suma);

//double tercerNumero = 7.5;
//double cuartoNumero = 3.5;
//double otraSuma;

//otraSuma = tercerNumero + cuartoNumero;

//Console.WriteLine(otraSuma);

//string nombre = "Matias";
//string apellido = "Smania";

//Console.WriteLine(nombre + " " + apellido);

//bool verdadero = true;
//bool falso = false;

//Console.WriteLine("Verdadero: " + verdadero);
//Console.WriteLine("Falso: " + falso);

///// CLASE #4 - Operadores Aritmeticos /////

//int Peru = 1 + 0 + 1 + 1;
//int Argentina = 3 + 3 + 1 + 3;
//int des = 2;
//int NuevoPeru = Peru - des;
//int NuevoArgentina = Argentina - des;
//int Brasil = 3 * 6;
//int NuevoBrasil = Brasil - (3 * des);
//int PartidosChile = 21 / 3;
//int Colombia = 17%3;

//Console.WriteLine("Los puntos de peru son: "+ Peru + "\n" + "Los puntos de argentina:"+Argentina);
//Console.WriteLine(NuevoPeru + "\n" + NuevoArgentina);
//Console.WriteLine("Los puntos de brasil son: "+ Brasil);
//Console.WriteLine("Los nuevos puntos de brasil son: " + NuevoBrasil);
//Console.WriteLine("Los partidos jugados de chile: "+ PartidosChile);
//Console.WriteLine("Los puntos obtenidos por empate fueron: " + Colombia);

///// CLASE #5 OPERADORES INCREMENTO Y DECREMENTO /////

//int a = 0;
//a += 5;
//Console.WriteLine(a);
//int b = 5;
//b -= 2;
//Console.WriteLine(b);

//for (int i = 0; i < 5; i++)
//{ 
//    Console.WriteLine(i);
//}

//for (int i = 5;i >=0; i-=2)
//{ 
//    Console.WriteLine(i);
//}

///// CONDICIONALES: IF-ELSE IF-ELSE - CLASE #6 /////

//int num1, num2;
//Console.WriteLine("Ingrese nota: ");
//num1 = int.Parse(Console.ReadLine());

//if (num1 > 11)
//{
//    Console.WriteLine("APROBASTE");
//}

//else if(num1<11 & num1>= 8)
//{
//    Console.WriteLine("A FINAL");
//    Console.WriteLine("Ingrese nota DEL FINAL: ");
//    num2 = int.Parse(Console.ReadLine());
//    if (num2 > 11)
//    {
//        Console.WriteLine("Aprobaste");
//    }
//    else
//    {
//        Console.WriteLine("SUSPENDISTE");
//    }
//}

//else
//{ 
//    Console.WriteLine("SUSPENDISTE");
//}

///// SWITCH - CLASE #7 ///// 

//int num;
//Console.WriteLine("Ingresa el numero");
//num = int.Parse(Console.ReadLine());

//switch(num)
//{
//    case 0:
//        Console.WriteLine("El numero es 0");
//        break;
//    case 1:
//        Console.WriteLine("El numero es 1");
//        break;
//    case 2:
//        Console.WriteLine("El numero es 2");
//        break;
//    default: Console.WriteLine("El numero es mayor o menor a 2");
//        break;
//}

///// CICLO FOR - CLASE #8 /////

//for (int i =0; i<=10; i++)
//{
//    Console.WriteLine("numero: "+i);
//}

///// CICLO WHILE - CLASE #9 /////

//int x = 10;
//while (x >= 0)
//{
//    Console.WriteLine("El numero es: "+x);
//    x--;
//}

//Console.WriteLine("Ingresa un numero");
//int y= int.Parse(Console.ReadLine());

//while (y<=50)
//{
//    Console.WriteLine(y);
//    y+=2;
//}

///// CICLO DO-WHILE - CLASE #10 /////

//int i = 0;
//do
//{
//    Console.WriteLine("el número es: " + i);
//    i++;
//}
//while (i<10);

///// METODOS - CLASE #11 /////

//class Programa
//{
//    static void Main()
//    {
//        Programa programa = new Programa();
//        programa.MostrarSuma();
//        programa.MostrarResta();
//        programa.MostrarMult();
//        programa.MostrarDivision();
//    }
//    public int Suma(int a, int b)
//    {
//        int suma = a + b;
//        return suma;
//    }
//    public void MostrarSuma()
//    {
//        int a = 4, b = 5;
//        int suma = Suma(a, b);
//        Console.WriteLine("La suma es: " + suma);
//    }

//    public int Resta(int a, int b)
//    {
//        int resta = a - b;
//        return resta;
//    }
//    public void MostrarResta()
//    {
//        int a = 5, b = 6;
//        int resta = Resta(a, b);
//        Console.WriteLine("La resta es: " + resta);
//    }

//    public int Multiplicacion(int a, int b)
//    {
//        int mult = a * b;
//        return mult;
//    }
//    public void MostrarMult()
//    {
//        int num1 = 6;
//        int num2 = 5;
//        int mult = Multiplicacion(num1, num2);
//        Console.WriteLine("la Multiplicacion es: " + mult);
//    }

//    public double Division(double a, double b)
//    {
//        double div = a / b;
//        return div;
//    }
//    public void MostrarDivision()
//    {
//        double num1 = 30;
//        double num2 = 5;
//        double div = Division(num1, num2);
//        Console.WriteLine("La division es: " + div);
//    }
//}

///// POO - CLASE #12 ////////
    
class Programa
{
    static void Main()
    {
        FigurasGeometricas figuras = new FigurasGeometricas();
        double area = figuras.AreaCirculo(12);
        double areaCuadrado = figuras.AreaCuadrado(5);
        Console.WriteLine("El area del circulo es: "+ area);
        Console.WriteLine("El area del cuadrado es: " + areaCuadrado);
    }

    class FigurasGeometricas
    {
        double pi = Math.PI; //3.14
        public double AreaCirculo(double radio)
        {
            double area = pi * radio * radio;
            return area;
        }
        public double AreaCuadrado(double lado)
        {
            double area = lado * lado;
            return area;
        }
    }
}
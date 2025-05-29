using System;

class Challenges
{
    static void Main(String[] args)
    {
        //Punto 1.
        imprimir10numeros();


        //Punto 2.
        int num1;
        int num2;
        Console.WriteLine("Ingrese 2 numeros por teclado para que sean sumados.");
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("El resultado es: " + Suma(num1, num2).ToString());

        //Punto 3.
        int num3;
        Console.WriteLine("Ingrese un numero por teclado para saber si es par.");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine(ParCheck(num3) ? "Es par" : "Es impar");

        //Punto 4.
        double radio;
        Console.Write("Ingresá el un numero por teclado que sea un radio del círculo, para calcular el area del mismo: ");
        radio = double.Parse(Console.ReadLine());
        Console.WriteLine("El área del círculo es:" + CalcularArea(radio).ToString());

        //Punto 5.
        int valor;
        Console.Write("Ingresá el número a buscar: ");
        valor = int.Parse(Console.ReadLine());
        int[] arreglo = { 1, 2, 3, 2, 4, 1, 1, 1, 2, 3, 3 };
        Console.WriteLine("El numero buscado aparece " + CuantasVeces(arreglo,valor) + " veces.");

    }

    static void imprimir10numeros()
    {
        Console.WriteLine("Numeros:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
    static int Suma(int a, int b)
    {
        int resultado;
        resultado = a + b;
        return resultado;
    }

    static bool ParCheck(int a)
    {
        bool EsPar = a % 2 == 0;
        return EsPar;
    }
     static double CalcularArea(double radio)
    {
        double area = 3.1416 * radio * radio ;
        return area;
    }

    static int CuantasVeces(int[] a, int buscado)
    {
        int contador = 0;
        foreach (int num in a)
        {
            if (num == buscado)
                contador++;
        }
        return contador;
    }

}
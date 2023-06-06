// See https://aka.ms/new-console-template for more information
using System;
using espacioCalculadora;

int menu=0;
double num=0;
bool anda = false;
string? stringNum = "";

while(!anda)
{
    Console.WriteLine("Ingrese un número");
    stringNum = Console.ReadLine();
    anda = double.TryParse(stringNum, out num);
    if(!anda)
    {
        Console.WriteLine("Valor inválido");
    }
}
anda = false;
Calculadora nuevo = new Calculadora();
nuevo.Limpiar();
nuevo.Sumar(num);
while(!anda)
{
    Console.WriteLine("Que desea hacer con el número: " + nuevo.Resultado + "?\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
    while(!anda || menu <= 0 || menu > 4)
    {
        stringNum = Console.ReadLine();
        anda = int.TryParse(stringNum, out menu);
        if(!anda || menu <= 0 || menu > 4)
        {
            Console.WriteLine("Valor inválido");
        }
    }

    Console.WriteLine("Ingrese el segundo número");
    anda = false;
    while(!anda)
    {
        stringNum = Console.ReadLine();
        anda = double.TryParse(stringNum, out num);
        if(!anda)
        {
            Console.WriteLine("Valor inválido");
        }
    }

    switch(menu)
    {
        case 1: nuevo.Sumar(num);
            break;
        case 2: nuevo.Restar(num);
            break;
        case 3: nuevo.Multiplicar(num);
            break;
        case 4: nuevo.Dividir(num);
            break;
    }
    Console.WriteLine($"El resultado es {nuevo.Resultado}");

    anda = false;
    menu = 0;
    while(!anda || menu < 0 || menu > 1)
    {
        Console.WriteLine("\nDesea seguir operando?\n0.No\n1.Si");
        stringNum = Console.ReadLine();
        anda = int.TryParse(stringNum, out menu);
        if(!anda || menu < 0 || menu > 1)
        {
            Console.WriteLine("Valor inválido");
        }
    }
    if(menu == 1)
    {
        anda = false;
    }
}
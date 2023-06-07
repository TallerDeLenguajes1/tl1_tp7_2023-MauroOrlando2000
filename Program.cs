// See https://aka.ms/new-console-template for more information
using System;
using espacioCalculadora;
using ListaDeEmpleados;

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

// EJERCICIO 2

Empleado empleado = new Empleado();
int anio = 0, mes = 1, dia = 1;
char estado = ' ';
double sueldo = 0;

anda = false;
while(!anda)
{
    Console.WriteLine("Ingrese el nombre del empleado");
    stringNum = Console.ReadLine();
    if(stringNum == null)
    {
        Console.WriteLine("Nombre inválido");
    }
    else
    {
        anda = true;
    }
}
empleado.Nombre = stringNum;
anda = false;
while(!anda)
{
    Console.WriteLine("Ingrese el apellido del empleado");
    stringNum = Console.ReadLine();
    if(stringNum == null)
    {
        Console.WriteLine("Apellido inválido");
    }
    else
    {
        anda = true;
    }
}
empleado.Apellido = stringNum;
anda = false;
while(!anda)
{
    Console.WriteLine("Ingrese la fecha de nacimiento del empleado");
    Console.WriteLine("Año");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out anio);
    if(!anda)
    {
        Console.WriteLine("Valor inválido");
    }
}
anda = false;
while(!anda || mes <= 0 || mes > 12)
{
    Console.WriteLine("Mes");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out mes);
    if(!anda || mes <= 0 || mes > 12)
    {
        Console.WriteLine("Valor inválido");
    }
}
anda = false;
while(!anda || dia <= 0 || dia > 31)
{
    Console.WriteLine("Dia");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out dia);
    if(!anda || dia <= 0 || dia > 31)
    {
        Console.WriteLine("Valor inválido");
    }
}
empleado.Nacimiento = new DateTime(anio, mes, dia);
anda = false;
while(!anda || (estado != 'S' && estado != 'C' && estado != 'V' && estado != 'D'))
{
    Console.WriteLine("Ingrese el estado civil del empleado\nS = Soltero\nC = Casado\nV = Viudo\nD = Divorciado");
    stringNum = Console.ReadLine();
    anda = char.TryParse(stringNum, out estado);
    if(!anda || (estado != 'S' && estado != 'C' && estado != 'V' && estado != 'D'))
    {
        Console.WriteLine("Valor inválido");
    }
}
empleado.EstadoCivil = estado;
anda = false;
while(!anda || (estado != 'M' && estado != 'F'))
{
    Console.WriteLine("Ingrese el género del empleado\nM = Masculino\nF= Femenino");
    stringNum = Console.ReadLine();
    anda = char.TryParse(stringNum, out estado);
    if(!anda || (estado != 'M' && estado != 'F'))
    {
        Console.WriteLine("Valor inválido");
    }
}
empleado.Genero = estado;
anda = false;
while(!anda)
{
    Console.WriteLine("Ingrese la fecha de ingreso del empleado");
    Console.WriteLine("Año");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out anio);
    if(!anda)
    {
        Console.WriteLine("Valor inválido");
    }
}
anda = false;
while(!anda || mes <= 0 || mes > 12)
{
    Console.WriteLine("Mes");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out mes);
    if(!anda || mes <= 0 || mes > 12)
    {
        Console.WriteLine("Valor inválido");
    }
}
anda = false;
while(!anda || dia <= 0 || dia > 31)
{
    Console.WriteLine("Dia");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out dia);
    if(!anda || dia <= 0 || dia > 31)
    {
        Console.WriteLine("Valor inválido");
    }
}
empleado.Ingreso = new DateTime(anio, mes, dia);
anda = false;
while(!anda || sueldo < 0)
{
    Console.WriteLine("Ingrese el sueldo básico del empleado");
    stringNum = Console.ReadLine();
    anda = double.TryParse(stringNum, out sueldo);
    if(!anda || sueldo < 0)
    {
        Console.WriteLine("Valor inválido");
    }
}
empleado.sueldo = sueldo;
anda = false;
while(!anda || anio < 0 || anio > 4)
{
    Console.WriteLine("Ingrese el cargo que ocupa el empleado");
    Console.WriteLine("0. Auxiliar\n1. Administrativo\n2. Ingeniero\n3. Especialista\n4. Investigador");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out anio);
    if(!anda || anio < 0 || anio > 4)
    {
        Console.WriteLine("Valor inválido");
    }
}
switch(anio)
{
    case 0: empleado.Cargo = Empleado.cargos.Auxiliar;
        break;
    case 1: empleado.Cargo = Empleado.cargos.Administrativo;
        break;
    case 2: empleado.Cargo = Empleado.cargos.Ingeniero;
        break;
    case 3: empleado.Cargo = Empleado.cargos.Especialista;
        break;
    case 4: empleado.Cargo = Empleado.cargos.Investigador;
        break;
}
Console.WriteLine($"{empleado.sueldo}");

DateTime antiguedad = empleado.calcularAntiguedad(empleado.Ingreso);
DateTime edad = empleado.calcularEdad(empleado.Nacimiento);
DateTime jubilacion = empleado.calcularJubilacion(empleado.Nacimiento, empleado.Genero);
Console.WriteLine($"El empleado tiene {antiguedad.Year} año/s, {antiguedad.Month} mes/es y {antiguedad.Day} dia/s en la empresa");
Console.WriteLine($"El empleado tiene {edad.Year} año/s, {edad.Month} mes/es y {edad.Day} dia/s de edad");
Console.WriteLine($"El empleado le quedan {jubilacion.Year} año/s, {jubilacion.Month} mes/es y {jubilacion.Day} dia/s para su jubilacion");
empleado.salario(empleado.sueldo, antiguedad, empleado.Cargo, empleado.EstadoCivil);
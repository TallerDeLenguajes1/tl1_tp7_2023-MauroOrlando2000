// See https://aka.ms/new-console-template for more information
using System;
using espacioCalculadora;
using ListaDeEmpleados;

int menu=0;
double num=0;
bool anda = false;
string? stringNum = "";

// while(!anda)
// {
//     Console.WriteLine("Ingrese un número");
//     stringNum = Console.ReadLine();
//     anda = double.TryParse(stringNum, out num);
//     if(!anda)
//     {
//         Console.WriteLine("Valor inválido");
//     }
// }
// anda = false;
// Calculadora nuevo = new Calculadora();
// nuevo.Limpiar();
// nuevo.Sumar(num);
// while(!anda)
// {
//     Console.WriteLine("Que desea hacer con el número: " + nuevo.Resultado + "?\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
//     while(!anda || menu <= 0 || menu > 4)
//     {
//         stringNum = Console.ReadLine();
//         anda = int.TryParse(stringNum, out menu);
//         if(!anda || menu <= 0 || menu > 4)
//         {
//             Console.WriteLine("Valor inválido");
//         }
//     }

//     Console.WriteLine("Ingrese el segundo número");
//     anda = false;
//     while(!anda)
//     {
//         stringNum = Console.ReadLine();
//         anda = double.TryParse(stringNum, out num);
//         if(!anda)
//         {
//             Console.WriteLine("Valor inválido");
//         }
//     }

//     switch(menu)
//     {
//         case 1: nuevo.Sumar(num);
//             break;
//         case 2: nuevo.Restar(num);
//             break;
//         case 3: nuevo.Multiplicar(num);
//             break;
//         case 4: nuevo.Dividir(num);
//             break;
//     }
//     Console.WriteLine($"El resultado es {nuevo.Resultado}");

//     anda = false;
//     menu = 0;
//     while(!anda || menu < 0 || menu > 1)
//     {
//         Console.WriteLine("\nDesea seguir operando?\n0.No\n1.Si");
//         stringNum = Console.ReadLine();
//         anda = int.TryParse(stringNum, out menu);
//         if(!anda || menu < 0 || menu > 1)
//         {
//             Console.WriteLine("Valor inválido");
//         }
//     }
//     if(menu == 1)
//     {
//         anda = false;
//     }
// }

// EJERCICIO 2

Empleado[] empleado = new Empleado[3];
DateTime[] antiguedad = new DateTime[3];
DateTime[] edad = new DateTime[3];
DateTime[] jubilacion = new DateTime[3];
int anio = 0, mes = 1, dia = 1;
char estado = ' ';
double sueldo = 0, salarioTotal = 0;

for(int i=0; i<3; i++)
{
    empleado[i] = new Empleado();
    anda = false;
    while(!anda)
    {
        Console.WriteLine("Ingrese el nombre del empleado " + (i+1));
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
    empleado[i].Nombre = stringNum;
    anda = false;
    while(!anda)
    {
        Console.WriteLine("Ingrese el apellido del empleado " + (i+1));
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
    empleado[i].Apellido = stringNum;
    anda = false;
    while(!anda)
    {
        Console.WriteLine("Ingrese la fecha de nacimiento del empleado " + (i+1));
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
    empleado[i].Nacimiento = new DateTime(anio, mes, dia);
    anda = false;
    while(!anda || (estado != 'S' && estado != 'C' && estado != 'V' && estado != 'D'))
    {
        Console.WriteLine("Ingrese el estado civil del empleado " + (i+1) + "\nS = Soltero\nC = Casado\nV = Viudo\nD = Divorciado");
        stringNum = Console.ReadLine();
        anda = char.TryParse(stringNum, out estado);
        if(!anda || (estado != 'S' && estado != 'C' && estado != 'V' && estado != 'D'))
        {
            Console.WriteLine("Valor inválido");
        }
    }
    empleado[i].EstadoCivil = estado;
    anda = false;
    while(!anda || (estado != 'M' && estado != 'F'))
    {
        Console.WriteLine("Ingrese el género del empleado " + (i+1) + "\nM = Masculino\nF= Femenino");
        stringNum = Console.ReadLine();
        anda = char.TryParse(stringNum, out estado);
        if(!anda || (estado != 'M' && estado != 'F'))
        {
            Console.WriteLine("Valor inválido");
        }
    }
    empleado[i].Genero = estado;
    anda = false;
    while(!anda)
    {
        Console.WriteLine("Ingrese la fecha de ingreso del empleado " + (i+1));
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
    empleado[i].Ingreso = new DateTime(anio, mes, dia);
    anda = false;
    while(!anda || sueldo < 0)
    {
        Console.WriteLine("Ingrese el sueldo básico del empleado " + (i+1));
        stringNum = Console.ReadLine();
        anda = double.TryParse(stringNum, out sueldo);
        if(!anda || sueldo < 0)
        {
            Console.WriteLine("Valor inválido");
        }
    }
    empleado[i].sueldo = sueldo;
    anda = false;
    while(!anda || anio < 0 || anio > 4)
    {
        Console.WriteLine("Ingrese el cargo que ocupa el empleado " + (i+1));
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
        case 0: empleado[i].Cargo = Empleado.cargos.Auxiliar;
        break;
        case 1: empleado[i].Cargo = Empleado.cargos.Administrativo;
        break;
        case 2: empleado[i].Cargo = Empleado.cargos.Ingeniero;
        break;
        case 3: empleado[i].Cargo = Empleado.cargos.Especialista;
        break;
        case 4: empleado[i].Cargo = Empleado.cargos.Investigador;
        break;
    }
    antiguedad[i] = empleado[i].calcularAntiguedad(empleado[i].Ingreso);
    edad[i] = empleado[i].calcularEdad(empleado[i].Nacimiento);
    jubilacion[i] = empleado[i].calcularJubilacion(empleado[i].Nacimiento, empleado[i].Genero);
    sueldo = empleado[i].salario(empleado[i].sueldo, antiguedad[i], empleado[i].Cargo, empleado[i].EstadoCivil);
    salarioTotal += sueldo;
    Console.WriteLine("El empleado " + (i+1) + $" tiene {antiguedad[i].Year} año/s, {antiguedad[i].Month} mes/es y {antiguedad[i].Day} dia/s en la empresa");
    Console.WriteLine("El empleado " + (i+1) + $" tiene {edad[i].Year} año/s, {edad[i].Month} mes/es y {edad[i].Day} dia/s de edad");
    Console.WriteLine("Al empleado " + (i+1) + $" le quedan {jubilacion[i].Year} año/s, {jubilacion[i].Month} mes/es y {jubilacion[i].Day} dia/s para su jubilacion");
    Console.WriteLine("El salario es " + sueldo);
}
Console.WriteLine("\nEl monto total en salarios es " + salarioTotal);

int mayor;
if(DateTime.Compare(jubilacion[0], jubilacion[1]) == -1)
{
    if(DateTime.Compare(jubilacion[0], jubilacion[2]) == -1)
    {
        mayor = 0;
    }
    else
    {
        mayor = 2;
    }
}
else
{
    if(DateTime.Compare(jubilacion[1], jubilacion[2]) == -1)
    {
        mayor = 1;
    }
    else
    {
        mayor = 2;
    }
}

Console.WriteLine("\nEl empleado mas cerca de jubilarse es el empleado " + (mayor+1));
Console.WriteLine("Nombre completo: " + empleado[mayor].Apellido + ", " + empleado[mayor].Nombre);
Console.WriteLine($"Fechad de nacimiento: {empleado[mayor].Nacimiento.Day}/{empleado[mayor].Nacimiento.Month}/{empleado[mayor].Nacimiento.Year}");
switch(empleado[mayor].Genero)
{
    case 'S': Console.WriteLine("Estado Civil: Soltero");
    break;
    case 'C': Console.WriteLine("Estado Civil: Casado");
    break;
    case 'V': Console.WriteLine("Estado Civil: Viudo");
    break;
    case 'D': Console.WriteLine("Estado Civil: Divorciado");
    break;
}
if(empleado[mayor].Genero == 'F')
{
    Console.WriteLine("Genero: Femenino");
}
else
{
    Console.WriteLine("Genero: Masculino");
}
Console.WriteLine($"Fecha de ingreso: {empleado[mayor].Ingreso.Day}/{empleado[mayor].Ingreso.Month}/{empleado[mayor].Ingreso.Year}");
Console.WriteLine("Sueldo básico: " + empleado[mayor].sueldo);
sueldo = empleado[mayor].salario(empleado[mayor].sueldo, antiguedad[mayor], empleado[mayor].Cargo, empleado[mayor].EstadoCivil);
Console.WriteLine("Salario: " + sueldo);
Console.WriteLine("Cargo: " + empleado[mayor].Cargo);
Console.WriteLine("El empleado " + (mayor+1) + $" tiene {antiguedad[mayor].Year} año/s, {antiguedad[mayor].Month} mes/es y {antiguedad[mayor].Day} dia/s en la empresa");
Console.WriteLine("El empleado " + (mayor+1) + $" tiene {edad[mayor].Year} año/s, {edad[mayor].Month} mes/es y {edad[mayor].Day} dia/s de edad");
Console.WriteLine("Al empleado " + (mayor+1) + $" le quedan {jubilacion[mayor].Year} año/s, {jubilacion[mayor].Month} mes/es y {jubilacion[mayor].Day} dia/s para su jubilacion");
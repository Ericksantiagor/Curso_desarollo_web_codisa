// Estructura de seleccion o desiones

int edad = 1;
int edad2 = 15;

int resultado = edad + edad2;


if (resultado >= 18)
{
    Console.WriteLine("Eres mayor de edad puedes votar");
}
else 
{

    Console.WriteLine("Eres menor de edad");
}


if (resultado % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else 
{
    Console.WriteLine("El numero es impar");
}

char letra = 'c';

switch(letra)
{
    case 'a':
        Console.WriteLine("la letra es a");
        break;

    case 'b':
        Console.WriteLine("la letra es b");
        break;

    default:
        Console.WriteLine("La letra no es a ni b");
        break;
}

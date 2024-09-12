using System;
using System.Collections.Generic;
using System.Security.Cryptography;


/*
// Calculadora Resuelve si el Numero ingresado es par o impar

Console.WriteLine("Ingrese un Numero Entero");

int NumeroParImpar = Convert.ToInt32(Console.ReadLine());

float resta = NumeroParImpar % 2;

Console.WriteLine(resta);

if (resta == 0)
    Console.WriteLine("TU numero es par");

else Console.WriteLine("Tu numero es Impar");



// Actividad 1
//Objetivo Crear un arreglo que imprima en pantalla Corchetes  con un numero y dependiendo si el numero es primo o no este se muestre distinto a los demas



*/

static bool EsPrimo(int numero)
{
    if (numero <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(numero); i++)
    {
        if (numero % i == 0) return false;
    }
    return true;
}



for (int i = 1; i <= 200; i++)
{
    if (i == 2)
    {
        // Imprimir en color rosado si es primo y Par
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"{i} es un número primo y Par.");
    }
    else if (i % 2 == 0)
    {
        // Imprimir en color azul si es par
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i} es un número par.");
    }
    else if (EsPrimo(i))
    {
        // Imprimir en color verde si es primo
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{i} es un número primo.");
    }
    else
    {
        // Imprimir en color rojo si es impar
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i} es un número impar.");
    }

    // Restablecer el color para la siguiente línea
    Console.ResetColor();
}
    

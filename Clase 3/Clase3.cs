//Metodos Vistos en la Clase 3

//cadenas nulas o vacías
string cadenaNula = null;
string cadenaVacia = String.Empty;
string cadenaConSaludo = "Hola! soy una cadena...";

//Concatenamos una cadena con datos una vacía y otra nula. La salida es: Hola! soy una cadena...
Console.WriteLine(cadenaConSaludo + cadenaNula + cadenaVacia);

//Vemos que no son iguales comparando una cadena nula y otra vacía
if (cadenaVacia == cadenaNula)
{
    Console.WriteLine("Las cadenas vacías y nulas son iguales!???");
}
else
{
    Console.WriteLine("Las cadenas vacías y nulas NO son iguales"); //esta será la salida!
}


//string equals/contains
string cadena1 = "Soy una cadena   ";
string cadena2 = "Soy una cadena";

if (cadena1.Equals(cadena2))
{
    Console.WriteLine("Cadena1 es igual a Cadena2");
}
else
{
    Console.WriteLine("Cadena1 no es igual a Cadena2");
}

if (cadena1.Contains(cadena2))
{
    Console.WriteLine("Cadena1 contiene a Cadena2");
}
else
{
    Console.WriteLine("Cadena1 no contiene a Cadena2");
}

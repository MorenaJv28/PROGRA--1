using Ejercicio;
Contar_Letra letra = new Contar_Letra();
int LETRA;

Console.WriteLine("Ingresa tu texto");

LETRA = letra.Letra(Console.ReadLine());
Console.WriteLine("Tu texto tiene " + LETRA + " Letra");
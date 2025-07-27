// See https://aka.ms/new-console-template for more information
int contador = int.Parse(Console.ReadLine());
int tiempo = int.Parse(Console.ReadLine());

while (contador < tiempo)
{
    Console.WriteLine($"Se ejecuta....:{contador}");

    contador =contador+1;
}
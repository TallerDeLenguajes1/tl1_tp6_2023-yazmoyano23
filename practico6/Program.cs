// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("valor de a: " +a);
Console.WriteLine("valor de b: " +b);

float floatNum1= 0;
bool anda = false;
string? numString = "";

while (!anda)
{
    Console.WriteLine("Ingrese un numero válido");
    numString = Console.ReadLine();
    anda = float.TryParse(numString, out floatNum1);
    if (!anda) {
        Console.WriteLine(numString + " no es numero válido.");   
    }

}

if (floatNum1 > 0 )
{
    while (aux)
    {
        
    }
}
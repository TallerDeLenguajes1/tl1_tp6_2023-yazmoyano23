// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("valor de a: " + a);
Console.WriteLine("valor de b: " + b);

int intNum1= 0;
bool anda = false;
string? numString = "";

while (!anda)
{
    Console.WriteLine("Ingrese un numero válido");
    numString = Console.ReadLine();
    anda = int.TryParse(numString, out intNum1);
    if (!anda) {
        Console.WriteLine(numString + " no es numero válido.");   
    }

}
int aux;
int resto;
int cantDigitos = 0;
double invertido = 0;
aux = intNum1;

 while(aux != 0){             
    aux = aux/10;         
    cantDigitos++;      
}

aux = intNum1;

if (intNum1 > 0 )
{
    while (aux != 0)
    {
        resto = aux % 10;
        invertido += (resto * Math.Pow(10,cantDigitos-1));
        aux = aux / 10;
        cantDigitos = cantDigitos - 1;
    }
}

Console.WriteLine("El numero invertido es: " + invertido);
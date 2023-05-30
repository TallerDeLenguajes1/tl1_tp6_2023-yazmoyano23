// See https://aka.ms/new-console-template for more information

bool anda = false;
string? numString = "";

//Calculadora V1

int num1=0, num2=0, operacion=0, resultado = 0;
string? Aux = "";
do
{
    //Control de la opcion ingresada
    while (!anda) {
        Console.WriteLine("Ingrese la operacion que desea realizar: (1:SUMAR 2:RESTAR 3:MULTIPLICAR 4:DIVIDIR)");
        numString = Console.ReadLine();
        anda = int.TryParse(numString, out operacion);
        //Control de numero
        if (!anda) {
            Console.WriteLine(numString + " no es numero válido.");   
        }
        if (operacion > 4 ){
            anda = false;
            Console.WriteLine(operacion + " no es una opción válida.");
        }
    }
    anda = false;
    //Control de ingreso de numeros
    while (!anda) {
        Console.WriteLine("Ingrese el primer número:");
        numString = Console.ReadLine();
        anda = int.TryParse(numString, out num1);
        //Control de numero
        if (!anda) {
            Console.WriteLine(numString + " no es numero válido.");   
        }
    }
    anda = false;

    while (!anda) {
        Console.WriteLine("Ingrese el segundo número");
        numString = Console.ReadLine();
        anda = int.TryParse(numString, out num2);
        //Control de numero
        if (!anda) {
                Console.WriteLine(numString + " no es numero válido.");   
        }
    }
    anda = false;

    //Operaciones
    if (operacion == 1) {
        resultado= num1 + num2;
        Console.WriteLine("El resultado de la suma es: " + resultado);
    } else {
        if (operacion == 2) {
            resultado= num1 - num2;
            Console.WriteLine("El resultado de la resta es: " + resultado);
        } else {
            if (operacion == 3) {
                resultado= num1 * num2;
                Console.WriteLine("El resultado de la multiplicación es: " + resultado);
            } else {
                //Falta controlar que num2 sea distinto de 0
                if (num2==0){
                        while (!anda) {
                            Console.WriteLine("Ingrese el segundo número");
                            numString = Console.ReadLine();
                            anda = int.TryParse(numString, out num2);
                            //Control de numero
                            if (!anda) {
                                    Console.WriteLine(numString + " no es numero válido.");   
                            }
                            if (num2 == 0)
                            {
                                anda = false;
                            }
                        }
                }
                resultado = num1 / num2;
                Console.WriteLine("El resultado de la division es: " + resultado);
            }
        }
    }

    anda = false;
    //Control para continuar operando
    while (!anda)
    {
        Console.WriteLine("Quiere realizar otra operacion? S: SI, N: NO");
        Aux = Console.ReadLine();
        if (Aux != "S" && Aux != "N") {
            anda = false;
        }else
        {
          anda=true;  
        }
    }

    anda= false;

} while (Aux == "S");




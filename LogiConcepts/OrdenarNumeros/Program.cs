
//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los
//números ingresados.

using Shared;
using System.Diagnostics.Metrics;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine("Ingrese 3 números diferentes.....");
    var num1 = ConsoleExtension.GetInt("Ingrese primer número: ");
    var num2 = ConsoleExtension.GetInt("Ingrese segundo número: ");
    var num3 = ConsoleExtension.GetInt("Ingrese tercer número: ");

    if (num1 == num2 || num1 == num3 || num2 == num3)
    {
        Console.WriteLine("Los números ingresados son iguales. Por favor ingrese números diferentes.");
    }
    else
    {
        if (num1 > num2 && num1 > num3)
        {
            if (num2 > num3)
            {
                Console.WriteLine($"El mayor es {num1}, el medio es {num2}, el menor es {num3}");
            }
            else
            {
                Console.WriteLine($"El mayor es {num1}, el medio es {num3}, el menor es {num2}");
            }
        }
        else if (num2 > num1 && num2 > num3)
        {
            if (num1 > num3)
            {
                Console.WriteLine($"El mayor es {num2}, el medio es {num1}, el menor es {num3}");
            }
            else
            {
                Console.WriteLine($"El mayor es {num2}, el medio es {num3}, el menor es {num1}");
            }


        }
        else
        {
            if (num1 > num2)
            {
                Console.WriteLine($"El mayor es {num3}, el medio es {num1}, el menor es {num2}");
            }
            else
            {
                Console.WriteLine($"El mayor es {num3}, el medio es {num2}, el menor es {num1}");
            }
        }
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
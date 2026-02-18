
//Construir un programa que pida dos número y diga si el segundo es múltiplo del primero.

using Shared;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Ingrese 2 números enteros...");
    var num1 = ConsoleExtension.GetInt("Ingrese primer número: ");
    var num2 = ConsoleExtension.GetInt("Ingrese segundo número: ");

    if (num1 == 0)
    {
        Console.WriteLine("No se puede hacer múltiplos con cero.");
    }
    else if (num2 % num1 == 0)
    {
        Console.WriteLine($"El número {num2} es múltiplo de {num1}.");
    }
    else
    {
        Console.WriteLine($"El número {num2} no es múltiplo de {num1}.");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
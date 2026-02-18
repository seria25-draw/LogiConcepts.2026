// See https://aka.ms/new-console-template for more information
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

//var numberString = string.Empty;
do
{
    //Console.WriteLine("Ingrese un número entero o la palabra 'Salir' para salir: ");
    //numberString = Console.ReadLine(); // number = "45" 
    //if (numberString!.ToLower() == "salir")
    //{
    //    continue;
    //}
    var number = ConsoleExtension.GetInt("Ingrese un número entero diferente de cero: ");
    //var numberInt = 0; 
    //if (int.TryParse(numberString, out numberInt))
    //{
        if (number == 0)
        {
            continue;
        }
        if (number % 2 == 0)
        {
            Console.WriteLine($"El número {number} es par.");
        }
        else
        {
            Console.WriteLine($"El número {number} es impar.");
        }

        do
        {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);
        }while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
    //}
    //else
    //{
    //    Console.WriteLine($"Lo que ingresaste: {numberString}, no es un número entero.");
    //}  
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game over :( ");
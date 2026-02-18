//Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.

using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var num1 = ConsoleExtension.GetInt("Ingrese primer número: ");
    var num2 = ConsoleExtension.GetInt("Ingrese segundo número: ");
    var num3 = ConsoleExtension.GetInt("Ingrese tercer número: ");

    if (num1 == 0 && num2 == 0 && num3 == 0)
    {
        break;
    }
    if (num1 == num2 && num2 == num3)
    {
        Console.WriteLine($"Los números ingresados son iguales: {num1}, {num2} y {num3}");
        continue;
    }
    var numMayor = num1;

    if (num2 > numMayor)
    {
        numMayor = num2;
    }
    if (num3 > numMayor)
    {
        numMayor = num3;
    }

    Console.WriteLine($"El número mayor es: {numMayor}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));



} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

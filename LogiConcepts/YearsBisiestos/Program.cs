//Construir un programa que pida un año y luego determine si el año es bisiesto o no. Tenga en cuenta que los años
//bisiestos son los números múltiplos de 4, pero que no son múltiplos de 100 y si son múltiplos de 100 y múltiplos de 400
//sí son bisiestos.

using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{   var yearActual = DateTime.Now.Year;
    var message = string.Empty;

    Console.WriteLine("Ingrese el año para calcular si es un año bisiesto...");
    var year = ConsoleExtension.GetInt("Ingrese un año : ");

    if (year == 0)
    {
        Console.WriteLine("El año no puede ser cero.");

    }
    else
    {
        if (year == yearActual)
        {
            message = "es";
        }
        else if (year < yearActual)
        {
            message = "fue";
        }
        else
        {
            message = "va a ser";
        }


        if (year % 400 == 0)
        {
            Console.WriteLine($"El año {year}, SI {message} un año bisiesto.");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine($"El año {year} NO {message} un año bisiesto.");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine($"El año {year}, SI {message} un año bisiesto.");
        }
        else
        {
            Console.WriteLine($"El año {year}, NO {message} un año bisiesto.");
        }
    }
     answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);

}while(answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

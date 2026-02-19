//Un almacén de escritorios hace los siguientes descuentos: si el cliente compra menos de 5 unidades se le da un
//descuento del 10% sobre la compra; si el número de unidades es mayor o igual a cinco pero menos de 10 se le otorga un
//20% y, si son 10 o más se le da un 40%.

//Hacer un programa que determine cuánto debe pagar un cliente si el valor de cada escritorio es de $650.000. 

// datos de entrada: cada escritorio cuesta $650.000
// - 5 unidades -> 10%
// unidades >= 5 y unidades <10 -> 20%
// unidades >= 10 -> 40%

using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Bienvenido al almacén");
    var numeroEscrit = ConsoleExtension.GetInt("Ingrese el número de escritorio a comprar: ");

    if (numeroEscrit <= 0)
    {
        Console.WriteLine("La cantidad debe ser mayor que cero.");
    }
    else
    {
        var totalCompra = CalculateValue(numeroEscrit);

        Console.WriteLine($"El valor total a apagar es: {totalCompra:C2}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculateValue(int numeroEscrit)
{
    const decimal valorEscritorio = 650000;
    decimal descuento;
    var totalCompra = numeroEscrit * valorEscritorio;

    if (numeroEscrit < 5)
    {
        descuento = totalCompra * 0.10m;
    }
    else if (numeroEscrit >= 5 && numeroEscrit < 10)
    {
        descuento = totalCompra * 0.20m;
    }
    else
    {
        descuento = totalCompra * 0.40m;
    }
    return totalCompra - descuento;
}
//Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula de la siguiente manera en un subprograma:

//• Si toma 20 o menos créditos, paga el crédito al valor normal.

//• Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.

//• Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:

// Si el estrato es 1, el descuento es del 80%.
// Si el estrato es 2, el descuento es del 50%.
// Si el estrato es 3, el descuento es del 30%.

//Además los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera (el cual se debe calcular en otro
//subprograma):

//• Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
//• Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.

//Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio. 

using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Bienvenidos, Por favor ingrese sus datos...");
    var numeroCred = ConsoleExtension.GetInt("Número de créditos: ");
    var valorCred = ConsoleExtension.GetDecimal("Valor de créditos: ");
    var estractoEstud = ConsoleExtension.GetInt("Estrato del estudiante: ");

    var costoMatricula = CalcularMatricula(numeroCred,valorCred,estractoEstud);
    var subsidio = CalcularSubsidio(estractoEstud);

    Console.WriteLine($"Costo de la matrícula: {costoMatricula:C2}");
    Console.WriteLine($"Valor del subsidio: {subsidio:C2}");
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

object CalcularMatricula(int numeroCred, decimal valorCred, int estractoEstud)
{
    decimal total;

    if (numeroCred <= 20)
    {
        total = numeroCred * valorCred;
    }
    else
    {
        int extras = numeroCred - 20;
        total = (20 * valorCred) + (extras * valorCred * 2);
    }
    decimal descuento = 0m;

    if (estractoEstud == 1)
    {
        return total * 0.80m;
    }
    if (estractoEstud == 2)
    {
        return total * 0.50m;
    }
    if (estractoEstud == 3)
    {
        return total * 0.30m;
    }
    else
    {
        return total -(total * descuento);
    }
}

object CalcularSubsidio(int estractoEstud)
{
    if (estractoEstud == 1)
    {
        return 200000m;
    }
    else if (estractoEstud == 2)
    {
        return 100000m;
    }
    else
    {
        return 0m;
    }
}






//Una empresa de envío de mercancías, tiene un plan de tarifas y descuentos sobre el valor del envío de mercancía de sus clientes:

//• Tarifas:
// Si el peso de la mercancía es inferior a 100 kg, la tarifa para el envío de ésta es de 20.000 pesos.
// Si el peso de la mercancía está entre 100 y 150 kg, la tarifa para el envío de ésta es de 25.000 pesos.
// Si el peso de la mercancía es superior a 150 kg y menor o igual a 200 kg, la tarifa para el envío de ésta es de 30.000
//pesos.
// Si el peso de la mercancía es superior a 200 kg, la tarifa es de 35.000 pesos y además por cada 10 kg adicionales se paga
//2.000 pesos.

//• Descuentos:
// Si el valor de la mercancía está entre 300.000 y 600.000 pesos se hace un descuento del 10% sobre el valor del envío.
// Si el valor de la mercancía es superior a 600.000 pero menor o igual a 1.000.000 de pesos se hace un descuento del 20%
//sobre el valor del envío.
// Si el valor de la mercancía es superior a 1.000.000 se hace un descuento del 30% sobre el valor del envío.

//• Promociones (solo hay dos tipos de pago):
// Si es día de promoción (lunes) y paga con tarjeta propia del almacén, sólo paga el 50% del costo de envío.
// Si paga en efectivo y el valor de la mercancía es superior a 1.000.000, sólo paga el 60% del costo de envío.
//Si el cliente aplica a una promoción, no puede aplicar a un descuento. Se debe obtener el valor total del envío. 


using Shared;
using System.Reflection.Metadata.Ecma335;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Bienvenidos a envíos de mercancías");
    var pesoMer = ConsoleExtension.GetFloat("Peso de la mercancía.....:");
    var valorMer = ConsoleExtension.GetDecimal("Valor de la mercancía: ");
    string esLunes;
    do
    {
        esLunes = ConsoleExtension.GetValidOptions("Es lunes [S]í [N]o:", options)!;
    } while (!options.Any(x => x.Equals(esLunes, StringComparison.CurrentCultureIgnoreCase)));

    var metodoPag = new List<string> { "e", "t" };
    string metodoPag;
    do
    {
        metodoPag = ConsoleExtension.GetValidOptions("Tipo de pago [E]fectivo [T]arjeta: ", metodoPag)!;
    } while (!options.Any(x => x.Equals(metodoPag, StringComparison.CurrentCultureIgnoreCase)));

    var valorTarif = CalculateValorTarif(pesoMer);
    var desc = CalculateDes(valorTarif, valorDes);
    decimal promocion = 0;

    if (desc == 0)
    {
        promocion = CalculatePromocion(valorTarif,esLunes, metodoPag);
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

decimal CalculatePromocion(object valorTarif, string esLunes, List<string> metodoPag)
{
    throw new NotImplementedException();
}

object CalculateDes(object valorTarif, object valorDes)
{
    if (valorMer >= 30000m && valorMer <= 600000m)
    {
        return valorTarif * 0.1m;
    }
    if (valorMer > 600000m && valorMer <= 1000000m)
    {
        return valorTarif * 0.2m;
    }
}

object CalculateValorTarif(float pesoMer)
{
    if (pesoMer <= 100)
    {
        return 20000m;
    }
    if (pesoMer <= 150)
    {
        return 25000m;
    }
    if (pesoMer <= 200)
    {
        return 30000m;
    }
    int adicionales = ((int)pesoMer - 200) /10;
    return 30000m + adicionales * 2000m;
}
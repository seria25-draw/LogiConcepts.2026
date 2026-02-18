//Elaborar un programa que entre el nombre de un empleado, su salario básico por hora y el número de horas trabajadas
//en el mes; escriba su nombre y salario mensual si éste es mayor del salario mínimo, de lo contrario escriba sólo el
//nombre. 

// datos de entrada: nombre_del_empleado,salario_basico_por_hora, numero_de_horas_trabajadas_en_el_mes

// codicion: escriba su nombre y salario mensual si éste es mayor del salario mínimo, de lo contrario escriba sólo el nombre. 


using Shared;
using static System.Runtime.InteropServices.JavaScript.JSType;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{

    var nombreEmpleado =  ConsoleExtension.GetString("Ingrese nombre: ");
    var horasTraj = ConsoleExtension.GetFloat("Ingrese número de horas trabajadas: ");
    var valorHor = ConsoleExtension.GetDecimal("Ingrese valor hora: ");
    var salarioMinim= ConsoleExtension.GetInt("Ingrese valor salario mínimo mensual:");

    var salarioMensual = (decimal) horasTraj * valorHor;


    if (salarioMensual < salarioMinim)
    {
        Console.WriteLine($"Nombre.....: {nombreEmpleado}");
        Console.WriteLine($"El salario minimo es.....: {salarioMinim:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre.....: {nombreEmpleado}");
        Console.WriteLine($"El salario mensual es.....: {salarioMensual:C2}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [s]í, [n]o?: ", options);

    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while(answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
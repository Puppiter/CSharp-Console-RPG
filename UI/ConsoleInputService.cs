
namespace jueguito.UI;

public class ConsoleInputService : IInputService
{
    public string SolicitarNombreDelHeroe()
    {
        string nombreDelHeroe = "";
        Console.WriteLine("A continuacion debes elegir un nombre.");
        do 
        {
        string? readResult = Console.ReadLine();
        if (readResult != null)
        {
            if (SolicitarConfirmacion($"¿Estas seguro que quieres que su nombre sea {readResult}?"))
            {
                return nombreDelHeroe = readResult;
            }
            else 
            {
                Console.WriteLine("Escribe el nombre que realmente quieres que tenga.");
            }
        }
        }while (true);
        
    }

    public int SeleccionarInt(int maximo, int minimo)
    {
        do
        {
            string? readResult = Console.ReadLine(); 
        if (readResult != null)
        {
            bool validInput = int.TryParse(readResult.Trim(), out int i);
            if (validInput)
                {
                 if (i >= minimo && i <= maximo)
                    {
                        return i;
                    }
                    else
                    {
                        Console.WriteLine("Por favor, seleccione una de las opciones.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, seleccione una de las opciones.");
                }
        }
        
        } while (true);
    }

    public bool SolicitarConfirmacion(string mensaje)
    {
                string? readResult;
        string respuesta = "";
        Console.WriteLine(mensaje);
        Console.WriteLine("(y/n)");
        do
        {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                respuesta = readResult.Trim().ToLower();
                if (respuesta == "y" || respuesta == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Por favor responda. \n(y/n)");
                }
            }
        } while (true);
        return respuesta switch
        {
            "y" => true,
            "n" => false,
            _ => throw new Exception("Error")
        };
    }

    public int SeleccionarClaseDelHeroe(IEnumerable<IEstadisticasBase> listaDeEstadisticas)
    {
        Console.WriteLine("Debes seleccionar una clase de heroe.")
        int i = 0;
        foreach (var estadisticas in listaDeEstadisticas)
            {
                i ++;
                Console.WriteLine($"{i}: {estadisticas.NombreDeClase}");           
            }
        return SeleccionarInt(i, 1);
    }

    public int SeleccionarClaseDelJefe(IEnumerable<IEstadisticasBase> listaDeEstadisticas)
{
    int i = 0;
    foreach (var estadisticas in listaDeEstadisticas)
    {
        i++;
        Console.WriteLine($"{i}: {estadisticas.NombreDeClase}");           
    }
    return SeleccionarInt(i, 1);
}
}  
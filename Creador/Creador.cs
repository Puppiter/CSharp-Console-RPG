using jueguito.Personajes;
using jueguito.Jefes;
using jueguito.Core;
using System.Reflection.Metadata;
using jueguito.UI;
namespace jueguito.Creador;

public static class Creadora
{
    public static Personaje CrearPersonaje()
    {
        string? readResult;
        string nombreDelHeroe = "";
        int i = 0;

        Console.WriteLine("Escribe el nombre del heroe");
        readResult = Console.ReadLine();
        if (readResult != null)
        { nombreDelHeroe = readResult.ToLower().Trim(); }


        do
        {
            Console.WriteLine("Selecciona la clase del heroe");
            Console.WriteLine("1. Barbaro");
            Console.WriteLine("2. Hechicero");
            Console.WriteLine("3. Paladin");
            Console.WriteLine("4. Vaquero");
            Console.WriteLine("5. Valquiria");

            readResult = Console.ReadLine();
            if (readResult != null)
            {
                bool validInput = int.TryParse(readResult.Trim(), out i);
                if (validInput)
                {
                    if (i > 0 && i < 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Por favor seleccione una de las 5 clases disponibles");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor seleccione una de las 5 clases disponibles");
                }
            }
        } while (true);
        return i switch
        {
            1 => new Barbaro(nombreDelHeroe + " el barbaro"),
            2 => new Hechicero(nombreDelHeroe + " el hechicero"),
            3 => new Paladin(nombreDelHeroe + " el paladin"),
            4 => new Vaquero(nombreDelHeroe + " el vaquero"),
            5 => new Valquiria(nombreDelHeroe + " la valquiria"),
            _ => throw new Exception("The Game, respiracion automatica desactivada")
        };
    }
    public static List<Personaje> CrearGrupoDeHeroes()
    {
        List<Personaje> grupoDeHeroes = new List<Personaje>();
        Interfaz.DesplegarInformacionDeHeroes();
        do
        {
            Personaje heroeNuevo = Creadora.CrearPersonaje();
            Console.WriteLine($"{heroeNuevo.Nombre} se ha unido al grupo de heroes.");
            Herramientas.LimpiezaDeConsola();
            grupoDeHeroes.Add(heroeNuevo);
            if (grupoDeHeroes.Count == 3)
            {
                break;
            }
        } while (true);
        return grupoDeHeroes;

    }
    public static Personaje SeleccionarJefe()
    {
        string? readResult;
        int i = 0;
        Interfaz.DesplegarInformacionDeJefes();
        do
        {
            Console.WriteLine("Selecciona el jefe que desees enfrentar:");
            Console.WriteLine("1. La Antigua Gorgona");
            Console.WriteLine("2. El Señor de los Gigantes");
            Console.WriteLine("3. El Renacido Rey del Hierro");
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                bool validInput = int.TryParse(readResult.Trim(), out i);
                if (validInput && i < 4 && i > 0)
                {
                    return i switch
                    {
                        1 => new JefeAntiguaGorgona(),
                        2 => new JefeSeñorDeLosGigantes(),
                        3 => new JefeRenacidoReyDeHierro(),
                        _ => throw new Exception("The Game, respiracion automatica desactivada")
                    };
                }
                else
                {
                    Console.WriteLine("Por favor, elige una de las opciones.");
                }
            }
        } while (true);

    }
}

using jueguito.Personajes;
using jueguito.Core;
using System.Reflection;
using jueguito.Jefes;

namespace jueguito.UI;



public static class Interfaz
{

    public static void MensajeDeAtaque(int dañoMagico, int dañoFisico, Personaje atacante, Personaje objetivo, string descripcionDeAtaque)
    {
        Console.WriteLine($"{atacante.Nombre} {descripcionDeAtaque} {objetivo.Nombre}");
        Console.WriteLine($"{objetivo.Nombre} ha recibido {dañoFisico} puntos de daño fisico");
        Console.WriteLine($"{objetivo.Nombre} ha recibido {dañoMagico} puntos de daño magico");
        Console.WriteLine($"A {objetivo.Nombre} le quedan {objetivo.Vida} puntos de vida");
    }

    public static string SolicitarNombreDelHeroe()
    {
        Console.WriteLine("Escribe el nombre del heroe:");
        string? entrada = Console.ReadLine();
        return string.IsNullOrWhiteSpace(entrada) ? "Desconocido" : entrada.Trim();
    }

    public static int SeleccionarClaseDelJefe()
    {
        DesplegarInformacionDeJefes();

        Console.WriteLine("Selecciona el jefe que desees enfrentar:");
        List<string> listaDeJefes = new List<string> { "La Antigua Gorgona", "El Señor de los Gigantes", "El Renacido Rey del Hierro" };
        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine($"{i}. {listaDeJefes[i - 1]}");
        }
        return SeleccionDeOpcion(1, listaDeJefes.Count);
    }

    public static void MensajeDeHeroeMuerto(Personaje heroe)
    {
        Console.WriteLine($"Oh no, {heroe.Nombre} ha caido derrotado.");
    }

    public static void MensajeDeGrupoDerrotado()
    {
        Console.WriteLine("Pese a sus esfuerzos, los heroes han sido derrotados.");
    }

    public static void MensajeDeJefeDerrotado(Personaje jefe)
    {
        Console.WriteLine($"Pese a su poder, {jefe.Nombre} fue derrotado por el grupo de heroes.");
    }

    public static void MostrarPartyYJefe(List<Personaje> grupoDeHeroes, Personaje jefe)
    {
        Console.WriteLine("Tu grupo de heroes se conforma por");
        foreach (Personaje heroeActual in grupoDeHeroes)
        {
            Console.WriteLine(heroeActual.Nombre);
        }
        Console.WriteLine($"Y han de enfrentarse a {jefe.Nombre}");
    }

    public static void TurnoDeAtaque(Personaje jefe)
    {
        Console.WriteLine($"Debes decidir que hacer en este turno, que heroe atacara, y cual intentara recibir el ataque de {jefe.Nombre}");
        Console.WriteLine("¿Quien atacara?");
    }
    public static void TurnoDeDefensa(Personaje jefe)
    {
        Console.WriteLine($"¿Quien intentara recibir el ataque de {jefe.Nombre}?");
    }

    public static void MensajeDeNuevoMiembro(Personaje heroe)
    {
        Console.WriteLine($"{heroe.Nombre} se ha unido al grupo.");
    }

    public static Personaje SeleccionarHeroe(List<Personaje> grupoDeHeroes)
    {
        for (int i = 1; i <= grupoDeHeroes.Count; i++)
        {
            Console.WriteLine($"{i}. {grupoDeHeroes[i - 1].Nombre}");
        }
        return grupoDeHeroes[SeleccionDeOpcion(1, grupoDeHeroes.Count)];
    }

    public static bool ObtenerConfirmacion(string mensaje)
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

    public static int SeleccionDeOpcion(int minimo, int maximo)
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

    public static int SeleccionarClaseDelHeroe()
    {
        List<string> clasesDeHeroes = new List<string> { "Barbaro", "Hechicero", "Paladin", "Vaquero", "Valquiria" };
        for (int j = 1; j < 6; j++)
        {
            Console.WriteLine($"{j}. {clasesDeHeroes[j - 1]}");
        }
        return SeleccionDeOpcion(1, clasesDeHeroes.Count);
    }
    public static void MensajeDeApertura()
    {
        Console.Clear();
        Console.WriteLine("Bienvenido al Juego, en este juego crearas un grupo de 3 heroes para enfrentarte a uno de los temibles jefes.");
        Herramientas.LimpiezaDeConsola();
        Console.WriteLine("En la seleccion de menus debes dar como input el indice numerico de la opcion que quieras seleccionar.");
        Console.WriteLine("El combate es simple, eliges a uno de los heroes para atacar, y a uno para intentar recibir el ataque del Jefe.");
        Console.WriteLine("Cada ataque, de heroes o del jefe tiene una pequeña probabilidad de dar un golpe critico.");
        Console.WriteLine("¡Comencemos!");
        Herramientas.LimpiezaDeConsola();
    }

    public static void DesplegarInformacionDeJefes()
    {
        List<Type> clasesDeJefes = new List<Type>
        {
            typeof(JefeAntiguaGorgona),
            typeof(JefeSeñorDeLosGigantes),
            typeof(JefeRenacidoReyDeHierro),
        };
        Console.WriteLine("Llego el momento de elegir el enemigo para esta aventura");
        Console.WriteLine($"Tienes {clasesDeJefes.Count} grandes jefes para elegir.");
        Herramientas.LimpiezaDeConsola();
        DesplegarInformacionDeClases(clasesDeJefes);
    }
    public static void DesplegarInformacionDeHeroes()
    {
        List<Type> clasesDeHeroes = new List<Type>
            {
                typeof(Barbaro),
                typeof(Hechicero),
                typeof(Paladin),
                typeof(Vaquero),
                typeof(Valquiria)
            };
        Console.WriteLine("Es hora de elegir los heroes para esta aventura");
        Console.WriteLine($"Tienes {clasesDeHeroes.Count} clases de heroes disponibles");
        Herramientas.LimpiezaDeConsola();
        DesplegarInformacionDeClases(clasesDeHeroes);
    }
    private static void DesplegarInformacionDeClases(List<Type> listaDeClases)
    {
        foreach (Type clase in listaDeClases)
        {
            var info = clase.GetCustomAttribute<InfoClaseAttribute>();

            if (info != null)
            {
                Console.WriteLine($"--- {info.Nombre} ---");
                Console.WriteLine(info.Descripcion);
                Console.WriteLine($"Estadisticas:\n Vida={info.Vida}\n Daño Fisico={info.DañoFisico}\n Daño magico={info.DañoMagico}\n Armadura={info.Armadura}\n Resistencia magica={info.ResistenciaMagica}");
                Herramientas.LimpiezaDeConsola();
            }
        }
    }
}
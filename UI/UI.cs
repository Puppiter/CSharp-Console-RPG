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
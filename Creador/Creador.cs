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
        string nombreDelHeroe = Interfaz.SolicitarNombreDelHeroe();
        int i = Interfaz.SeleccionarClaseDelHeroe();
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
        int i = Interfaz.SeleccionarClaseDelJefe();
        return i switch
        {
            1 => new JefeAntiguaGorgona(),
            2 => new JefeSeñorDeLosGigantes(),
            3 => new JefeRenacidoReyDeHierro(),
            _ => throw new Exception("The Game, respiracion automatica desactivada")
        };


    }
}

using jueguito.Personajes;
using jueguito.Jefes;
using jueguito.Core;
using System.Reflection.Metadata;
using jueguito.UI;
namespace jueguito.Creador;

public static class Creadora
{
    public static Personaje CrearPersonaje(IInputService _Is,IMessageService _Ms, IEnumerable<IEstadisticasBase> listaDeClasesDeHeroes)
    {
        
        int i = _Is.SeleccionarClaseDelHeroe(listaDeClasesDeHeroes);
        string nombreDelHeroe = _Is.SolicitarNombreDelHeroe();
        return i switch
        {
            1 => new Barbaro(nombreDelHeroe + " el barbaro"),
            2 => new Hechicero(nombreDelHeroe + " el hechicero"),
            3 => new Paladin(nombreDelHeroe + " el paladin"),
            4 => new Vaquero(nombreDelHeroe + " el vaquero"),
            5 => new Valquiria(nombreDelHeroe + " la valquiria"),
            _ => throw new Exception("Error al seleccionar clase del heroe.")
        };
    }
    public static List<Personaje> CrearGrupoDeHeroes(IInputService _Is,IMessageService _Ms,  IEnumerable<IEstadisticasBase> listaDeClasesDeHeroes)
    {
        List<Personaje> grupoDeHeroes = new List<Personaje>();
        _Ms.MostrarInformacionDeClases(listaDeClasesDeHeroes);
        do
        {
            Personaje heroeNuevo = Creadora.CrearPersonaje(_Is, _Ms, listaDeClasesDeHeroes);
            _Ms.MensajeDeNuevoMiembro(heroeNuevo.Nombre);
            grupoDeHeroes.Add(heroeNuevo);
            if (grupoDeHeroes.Count == 3)
            {
                break;
            }
        } while (true);
        return grupoDeHeroes;

    }
    public static Personaje SeleccionarJefe(IInputService _Is,IMessageService _Ms,  IEnumerable<IEstadisticasBase> listaDeClasesDeJefes)
    {
        _Ms.MostrarInformacionDeJefes(listaDeClasesDeJefes);
        int i = _Is.SeleccionarClaseDelJefe(listaDeClasesDeJefes);
        return i switch
        {
            1 => new JefeAntiguaGorgona(),
            2 => new JefeSeñorDeLosGigantes(),
            3 => new JefeRenacidoReyDeHierro(),
            _ => throw new Exception("Error en la seleccion de la clase del jefe.")
        };


    }
}

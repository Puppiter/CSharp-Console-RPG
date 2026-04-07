namespace jueguito.UI;

using jueguito.Personajes;
using System.Linq;
public class ConsoleMessageService : IMessageService
{
    public void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
    public void MensajeDeAtaque(int dañoMagico, int dañoFisico, int vidaRestanteDelObjetivo, string nombreDelAtacante, string nombreDelObjetivo, string descripcionDeAtaque)
    {
        Console.WriteLine($"{nombreDelAtacante} {descripcionDeAtaque} {nombreDelObjetivo}");
        Console.WriteLine($"{nombreDelObjetivo} ha recibido {dañoFisico} puntos de daño fisico");
        Console.WriteLine($"{nombreDelObjetivo} ha recibido {dañoMagico} puntos de daño magico");
        Console.WriteLine($"A {nombreDelObjetivo} le quedan {vidaRestanteDelObjetivo} puntos de vida");
    }

    public void MensajeDeHeroeMuerto(string nombreDelHeroe)
    {
        Console.WriteLine($"Oh no, {nombreDelHeroe} ha muerto por sus heridas.");
    }

    public void MensajeDeGrupoDerrotado()
    {
        Console.WriteLine("Pese a sus esfuerzos, los heroes han sido derrotados.");
    }

    public void MensajeDeApertura()
    {
        Console.WriteLine("Bienvenido al Juego, en este juego crearas un grupo de 3 heroes para enfrentarte a uno de los temibles jefes.");
        Console.WriteLine("En la seleccion de menus debes dar como input el indice numerico de la opcion que quieras seleccionar.");
        Console.WriteLine("El combate es simple, eliges a uno de los heroes para atacar, y a uno para intentar recibir el ataque del Jefe.");
        Console.WriteLine("Cada ataque, de heroes o del jefe tiene una pequeña probabilidad de dar un golpe critico.");
        Console.WriteLine("¡Comencemos!");
    }

    public void MostrarInformacionDeClases(IEnumerable<IEstadisticasBase> listaDeEstadisticas)
    {
        foreach (var estadisticas in listaDeEstadisticas)
        {
            Console.WriteLine($"Clase: {estadisticas.NombreDeClase}");
            Console.WriteLine($"Descripcion de Clase: {estadisticas.DescripcionDeClase}");
            Console.WriteLine($"Estadisticas:\n Vida={estadisticas.Vida}\n Daño Fisico={estadisticas.DañoFisico}\n Daño magico={estadisticas.DañoMagico}\n Armadura={estadisticas.Armadura}\n Resistencia magica={estadisticas.ResistenciaMagica}");
        }
    }

    public void MensajeDeJefeDerrotado(string NombreDelJefe)
    {
        Console.WriteLine($"Pese a su poder, {NombreDelJefe} ha caido derrotado");
    }

    public void TurnoDeAtaque(string nombreDelJefe)
    {
        Console.WriteLine($"Debes decidir que hacer en este turno, que heroe atacara, y cual intentara recibir el ataque de {nombreDelJefe}");
        Console.WriteLine("¿Quien atacara?");
    }

    public void TurnoDeDefensa(string nombreDelJefe)
    {
        Console.WriteLine($"¿Quien intentara recibir el ataque de {nombreDelJefe}?");
    }

    public void MostrarInformacionDeJefes(IEnumerable<IEstadisticasBase> listaDeClasesDeJefes)
    {
        Console.WriteLine("Llego el momento de elegir el enemigo para esta aventura");
        Console.WriteLine($"Tienes {listaDeClasesDeJefes.Count()} grandes jefes para elegir.");
        MostrarInformacionDeClases(listaDeClasesDeJefes);
    }

        public void MostrarInformacionDeHeroes(IEnumerable<IEstadisticasBase> listaDeClasesDeHeroes)
    {
        Console.WriteLine("Llego el momento de elegir los heroes para esta aventura");
        Console.WriteLine($"Tienes {listaDeClasesDeHeroes.Count()} clases de heroes para elegir.");
        MostrarInformacionDeClases(listaDeClasesDeHeroes);
    }

        public void MostrarPartyYJefe(List<string> nombresDelGrupoDeHeroes,List<string> clasesDelGrupoDeHeroes, string nombreDelJefe)
    {
        Console.WriteLine("Tu grupo de heroes se conforma por");
        for (int i = 0; i<nombresDelGrupoDeHeroes.Count; i++)
        {
            Console.WriteLine($"{nombresDelGrupoDeHeroes[i]} el {clasesDelGrupoDeHeroes[i]}");
        }
        Console.WriteLine($"Y han de enfrentarse a {nombreDelJefe}");
    }
}
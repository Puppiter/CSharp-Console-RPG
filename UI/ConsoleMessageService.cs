namespace jueguito.UI;

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
}
using jueguito.Personajes;
using jueguito.Core;
using System.Collections.Generic;
using jueguito.UI;
namespace jueguito
{
    public class Program
{	public static void Main()
	{
		ConsoleMessageService instancia = new ConsoleMessageService();
		Juego nuevoJuego = new Juego(instancia);
        nuevoJuego.IniciarJuego();
	}
}
}
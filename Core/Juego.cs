using jueguito.Personajes;
using jueguito.Creador;
namespace jueguito.Core;

using System.Collections.Generic;
using System.Timers;
using jueguito.Jefes;
using jueguito.UI;

public class Juego
{
    public Juego()
    {
    }

    public void IniciarJuego()
    {
        Console.Clear();
        Console.WriteLine("Bienvenido al Juego, en este juego crearas un grupo de 3 heroes para enfrentarte a uno de los temibles jefes.");
        Herramientas.LimpiezaDeConsola();
        Console.WriteLine("El combate es simple, eliges a uno de los heroes para atacar, y a uno para cubrir.");
        Console.WriteLine("El jefe a su vez atacara, pero hay una pequeña probabilidad de que ignore a quien elegiste para recibir el golpe, y golpee a otro heroe");
        Console.WriteLine("¡Comencemos!");
        Herramientas.LimpiezaDeConsola();
        do
        {
            List<Personaje> grupoDeHeroes = Creadora.CrearGrupoDeHeroes();
            Personaje jefe = Creadora.SeleccionarJefe();
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("Tu grupo de heroes se conforma por");
            foreach (Personaje heroeActual in grupoDeHeroes)
            {
                Console.WriteLine(heroeActual.Nombre);
            }
            Console.WriteLine($"Y han de enfrentarse a {jefe.Nombre}");
            Herramientas.LimpiezaDeConsola();
            LoopDeJuego(grupoDeHeroes, jefe);
        } while (JugarOtraVez());
    }

    public bool JugarOtraVez()
    {
        string? readResult;
        string respuesta = "";
        Console.WriteLine("Esta partida ha terminado.");
        Console.WriteLine("¿Deseas jugar otra vez?");
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
    public void LoopDeJuego(List<Personaje> grupoDeHeroes, Personaje jefe)
    {
        do
        {
            SeleccionarAccion(grupoDeHeroes, jefe);

            if (grupoDeHeroes.Count == 0)
            {
                break;
            }
            if (VerificarJefe(jefe))
            {
                break;
            }

        } while (true);
    }

    public bool VerificarJefe(Personaje jefe)
    {
        if (jefe.Vida < 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SeleccionarAccion(List<Personaje> grupoDeHeroes, Personaje jefe)
    {

        Console.WriteLine($"Debes decidir que hacer en este turno, que heroe atacara, y cual intentara recibir el ataque de {jefe.Nombre}");

        Console.WriteLine("¿Quien atacara?");
        Ataque(SeleccionarHeroe(grupoDeHeroes), jefe);
        Herramientas.LimpiezaDeConsola();
        if (VerificarJefe(jefe))
        {
            Console.WriteLine($"Pese a su poder {jefe.Nombre} ha caido ante el grupo de heroes.");
            return;
        }
        Console.WriteLine($"¿Quien intentara recibir el ataque de {jefe.Nombre}?");
        Ataque(jefe, SeleccionarHeroe(grupoDeHeroes));
        Herramientas.LimpiezaDeConsola();
        grupoDeHeroes = VerificarGrupoDeHeroes(grupoDeHeroes);
    }

    public Personaje SeleccionarHeroe(List<Personaje> grupoDeHeroes)
    {
        int j;
        string? readResult;
        do
        {

            for (int i = grupoDeHeroes.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"{i}. {grupoDeHeroes[i].Nombre}");
            }
            readResult = Console.ReadLine();
            if (readResult != null)
            {
                bool validInput = int.TryParse(readResult.Trim(), out j);
                if (validInput && j < grupoDeHeroes.Count && j >= 0)
                {
                    return grupoDeHeroes[j];
                }
                else
                {
                    Console.WriteLine("Por favor seleccionar uno de los heroes.");
                }
            }
        } while (true);
    }

    private void Ataque(Personaje atacante, Personaje objetivo)
    {
        int dañoFisico = atacante.DañoFisico;
        int dañoMagico = atacante.DañoMagico;
        string mensajeDeAtaque = atacante.DescripcionDeAtaque;
        if (Random.Shared.Next(0, 100) < 20)
        {
            dañoFisico = (atacante.DañoFisico * 150) / 100;
            dañoMagico = (atacante.DañoMagico * 150) / 100;
            mensajeDeAtaque = atacante.DescripcionDeAtaqueCritico;
        }
        int dañoMagicoFinal = objetivo.RecibirDañoMagico(dañoMagico);
        int dañoFisicoFinal = objetivo.RecibirDañoFisico(dañoFisico);
        Interfaz.MensajeDeAtaque(dañoMagicoFinal, dañoFisicoFinal, atacante, objetivo, mensajeDeAtaque);

    }
    public List<Personaje> VerificarGrupoDeHeroes(List<Personaje> grupoDeHeroes)
    {
        for (int i = grupoDeHeroes.Count - 1; i >= 0; i--)
        {
            if (grupoDeHeroes[i].Vida < 1)
            {
                Console.WriteLine($"Oh no, {grupoDeHeroes[i].Nombre} ha caido derrotado.");
                Herramientas.LimpiezaDeConsola();
                grupoDeHeroes.RemoveAt(i);
            }
        }
        if (grupoDeHeroes.Count == 0)
        {
            Console.WriteLine("El grupo de heroes ha sido derrotado.");
        }
        return grupoDeHeroes;
    }








}


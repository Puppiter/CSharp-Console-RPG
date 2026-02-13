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
        Interfaz.MensajeDeApertura();
        do
        {
            List<Personaje> grupoDeHeroes = Creadora.CrearGrupoDeHeroes();
            Personaje jefe = Creadora.SeleccionarJefe();
            Interfaz.MostrarPartyYJefe(grupoDeHeroes, jefe);
            LoopDeJuego(grupoDeHeroes, jefe);
        } while (Interfaz.ObtenerConfirmacion("¿Deseas jugar otra vez?"));
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

        Interfaz.TurnoDeAtaque(jefe);
        Ataque(Interfaz.SeleccionarHeroe(grupoDeHeroes), jefe);
        if (VerificarJefe(jefe))
        {
            Interfaz.MensajeDeJefeDerrotado(jefe);
            return;
        }
        Interfaz.TurnoDeDefensa(jefe);
        Ataque(jefe, Interfaz.SeleccionarHeroe(grupoDeHeroes));
        grupoDeHeroes = VerificarGrupoDeHeroes(grupoDeHeroes);
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
                Interfaz.MensajeDeHeroeMuerto(grupoDeHeroes[i]);
                grupoDeHeroes.RemoveAt(i);
            }
        }
        if (grupoDeHeroes.Count == 0)
        {
            Interfaz.MensajeDeGrupoDerrotado();
        }
        return grupoDeHeroes;
    }








}


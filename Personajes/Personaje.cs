namespace jueguito.Personajes;
using jueguito.Core;
public abstract class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; protected set; }
    public int DañoFisico { get; protected set; }
    public int DañoMagico { get; protected set; }
    public int Armadura { get; protected set; }
    public int ResistenciaMagica { get; protected set; }

    public string DescripcionDeAtaque { get; protected set; }

    public string DescripcionDeAtaqueCritico { get; protected set; }

    public Personaje(string nombre, IEstadisticasBase estadisticas)
    {
        Nombre = nombre;
        Vida = estadisticas.Vida;
        DañoFisico = estadisticas.DañoFisico;
        DañoMagico = estadisticas.DañoMagico;
        Armadura = estadisticas.Armadura;
        ResistenciaMagica = estadisticas.ResistenciaMagica;
        DescripcionDeAtaque = estadisticas.DescripcionDeAtaque;
        DescripcionDeAtaqueCritico = estadisticas.DescripcionDeAtaqueCritico;
    }

    public int RecibirDañoMagico(int cantidad)
    {
        int dañoFinal = cantidad - (cantidad * ResistenciaMagica) / 100;
        if (dañoFinal < 0)
        {
            dañoFinal = 1;
        }
        Vida -= dañoFinal;
        if (Vida < 1)
        {
            Vida = 0;
        }
        return dañoFinal;
    }

    public int RecibirDañoFisico(int cantidad)
    {
        int dañoFinal = cantidad - (cantidad * Armadura) / 100;
        if (dañoFinal < 0)
        {
            dañoFinal = 1;
        }
        Vida -= dañoFinal;

        if (Vida < 1)
        {
            Vida = 0;
        }
        return dañoFinal;
    }
}


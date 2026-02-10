namespace jueguito.Personajes;

public class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; protected set; }
    public int DañoFisico { get; protected set; }
    public int DañoMagico { get; protected set; }
    public int Armadura { get; protected set; }
    public int ResistenciaMagica { get; protected set; }

    public string DescripcionDeAtaque { get; protected set; }

    public string DescripcionDeAtaqueCritico { get; protected set; }

    public Personaje(string nombre)
    {
        Nombre = nombre;
        Vida = 100;
        Armadura = 0;
        DañoFisico = 10;
        ResistenciaMagica = 0;
        DescripcionDeAtaque = "Ataca a";
        DescripcionDeAtaqueCritico = "Ataca Fatalmente a";
    }

    public int RecibirDañoMagico(int cantidad)
    {
        int dañoFinal = cantidad - (cantidad * ResistenciaMagica) / 100;
        if (dañoFinal < 1)
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
        if (dañoFinal < 1)
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


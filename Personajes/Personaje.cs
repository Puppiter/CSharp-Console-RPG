namespace jueguito.Personajes;

public class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; protected set; }

    public int DañoFisico { get; protected set; }
    public int DañoMagico { get; protected set; }
    public int Armadura { get; protected set; }
    public int ResistenciaMagica { get; protected set; }

    public Personaje(string nombre)
    {
        Nombre = nombre;
        Vida = 100;
        Armadura = 0;
        DañoFisico = 10;
        ResistenciaMagica = 0;
    }

    public void RecibirDañoMagico(int cantidad)
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
        Console.WriteLine($"{Nombre} ha recibido {dañoFinal} de daño magico.");
    }

    public void RecibirDañoFisico(int cantidad)
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
        Console.WriteLine($"{Nombre} ha recibido {dañoFinal} de daño Fisico");
    }

    public void VidaActual(Personaje objetivo)
    {
        Console.WriteLine($"A {objetivo.Nombre} le quedan {objetivo.Vida} puntos de vida.");
    }

    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} ha lanzado un ataque a {objetivo.Nombre}");
        objetivo.RecibirDañoFisico(DañoFisico);
        objetivo.RecibirDañoMagico(DañoMagico);
        VidaActual(objetivo);
    }
}


namespace jueguito.Personajes;
using jueguito.Core;
using System.Reflection;


[InfoClase("", "",0 ,0, 0, 0, 0)]
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
        var info = this.GetType().GetCustomAttribute<InfoClaseAttribute>();

        if (info != null) 
        {
            this.Vida = info.Vida;
            this.DañoFisico = info.DañoFisico;
            this.DañoMagico = info.DañoMagico;
            this.Armadura = info.Armadura;
            this.ResistenciaMagica = info.ResistenciaMagica;
        }
        DescripcionDeAtaque = "Ataca a";
        DescripcionDeAtaqueCritico = "Ataca Fatalmente a";
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


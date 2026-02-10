namespace jueguito.Core;

using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
public class InfoClaseAttribute : Attribute
{
    public string Nombre { get; }
    public string Descripcion { get; }
    public int Vida {get;}
    public int DañoFisico {get;}
    public int DañoMagico {get;}
    public int Armadura {get;}
    public int ResistenciaMagica {get;}

    public InfoClaseAttribute(string nombre, string descripcion, int vida , int dañoFisico, int dañoMagico, int armadura, int resistenciaMagica)
    {
        Nombre = nombre;
        Descripcion = descripcion;
        Vida = vida;
        DañoFisico = dañoFisico;
        DañoMagico = dañoMagico;
        Armadura = armadura;
        ResistenciaMagica = resistenciaMagica;
    }
}



namespace jueguito.Personajes;

public class Barbaro : Personaje
{
    public Barbaro(string nombre) : base(nombre)
    {
        Nombre = nombre;
        Vida = 100;
        DañoFisico = 35;
        DañoMagico = 0;
        Armadura = 30;
        ResistenciaMagica = 0;
        DescripcionDeAtaque = "lanza un ataque brutal con su Hacha de Batalla sobre";
        DescripcionDeAtaqueCritico = "entra en un frenesí asesino y descarga un golpe devastador sobre";
    }
}
public class Hechicero : Personaje
{
    public Hechicero(string nombre) : base(nombre)
    {
        Nombre = nombre;
        Vida = 100;
        DañoFisico = 0;
        DañoMagico = 50;
        Armadura = 0;
        ResistenciaMagica = 0;
        DescripcionDeAtaque = "castea una poderosa bola de fuego hacia";
        DescripcionDeAtaqueCritico = "canaliza el poder del cosmos en una explosión de energía pura contra";
    }
}
public class Paladin : Personaje
{
    public Paladin(string nombre) : base(nombre)
    {
        Nombre = nombre;
        Vida = 100;
        DañoFisico = 15;
        DañoMagico = 15;
        Armadura = 18;
        ResistenciaMagica = 18;
        DescripcionDeAtaque = "arremete con su martillo sacro contra";
        DescripcionDeAtaqueCritico = "invoca la justicia divina y aplasta con un impacto sagrado a";
    }
}
public class Vaquero : Personaje
{
    public Vaquero(string nombre) : base(nombre)
    {
        Nombre = nombre;
        Vida = 100;
        DañoFisico = 50;
        DañoMagico = 0;
        Armadura = 0;
        ResistenciaMagica = 0;
        DescripcionDeAtaque = "vacio el cargador de su revolver sobre";
        DescripcionDeAtaqueCritico = "ajusta su sombrero y vacía el tambor de su revolver con precisión quirúrgica en";
    }
}
public class Valquiria : Personaje
{
    public Valquiria(string nombre) : base(nombre)
    {
        Nombre = nombre;
        Vida = 100;
        DañoFisico = 0;
        DañoMagico = 35;
        Armadura = 0;
        ResistenciaMagica = 30;
        DescripcionDeAtaque = "embiste con su lanza a";
        DescripcionDeAtaqueCritico = "desciende con la furia de los cielos y golpea el alma de";
    }
}


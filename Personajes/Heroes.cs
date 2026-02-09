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
    }

    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} lanza un ataque brutal con su Hacha de Batalla sobre {objetivo.Nombre}");
        objetivo.RecibirDañoFisico(DañoFisico);
        objetivo.RecibirDañoMagico(DañoMagico);
        VidaActual(objetivo);
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
    }
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} castea una poderosa bola de fuego hacia {objetivo.Nombre}");
        objetivo.RecibirDañoFisico(DañoFisico);
        objetivo.RecibirDañoMagico(DañoMagico);
        VidaActual(objetivo);
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
    }
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} arremete con su martillo sacro contra {objetivo.Nombre}");
        objetivo.RecibirDañoFisico(DañoFisico);
        objetivo.RecibirDañoMagico(DañoMagico);
        VidaActual(objetivo);
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
    }
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} vacio el cargador de su revolver sobre {objetivo.Nombre}");
        objetivo.RecibirDañoFisico(DañoFisico);
        objetivo.RecibirDañoMagico(DañoMagico);
        VidaActual(objetivo);
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
    }
    public override void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} desata su poder contra {objetivo.Nombre}");
        objetivo.RecibirDañoFisico(DañoFisico);
        objetivo.RecibirDañoMagico(DañoMagico);
        VidaActual(objetivo);
    }
}


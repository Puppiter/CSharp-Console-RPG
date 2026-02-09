namespace jueguito.Personajes
{
    public class Personaje
{
    public string Nombre { get; set; }
    public int Vida { get; protected set; }
    public int Armadura { get; protected set; }
    public int ResistenciaMagica { get; protected set; }

    public Personaje(string nombre)
    {
        Nombre = nombre;
        Vida = 100;
        Armadura = 0;
        ResistenciaMagica = 0;
    }

    public void RecibirDañoMagico(int cantidad)
    {
        int dañoFinal = cantidad - (cantidad / 100) * ResistenciaMagica;
        Vida -= dañoFinal;
        if (Vida < 1)
            {
                Vida = 0;
            }
        Console.WriteLine($"{Nombre} ha recibido {cantidad} de daño magico.");
    }

    public void RecibirDañoFisico(int cantidad)
    {
        int dañoFinal = cantidad - (cantidad / 100) * Armadura;
        Vida -= dañoFinal;
        if (Vida < 1)
            {
                Vida = 0;
            }
        Console.WriteLine($"{Nombre} ha recibido {cantidad} de daño Fisico");
    }

    public void VidaActual(Personaje objetivo)
    {
        Console.WriteLine($"A {objetivo.Nombre} le quedan {objetivo.Vida} puntos de vida.");
    }

    public virtual void Atacar(Personaje objetivo)
    {
        Console.WriteLine($"{Nombre} ha lanzado un ataque a {objetivo.Nombre}");
        objetivo.RecibirDañoFisico(10);
        objetivo.RecibirDañoMagico(0);
        VidaActual(objetivo);
    }
}

}
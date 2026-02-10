using jueguito.Personajes;

namespace jueguito.UI;

public static class Interfaz
{
    public static void MensajeDeAtaque(int dañoMagico, int dañoFisico, Personaje atacante, Personaje objetivo, string descripcionDeAtaque)
    {
        Console.WriteLine($"{atacante.Nombre} {descripcionDeAtaque} {objetivo.Nombre}");
        Console.WriteLine($"{objetivo.Nombre} ha recibido {dañoFisico} puntos de daño fisico");
        Console.WriteLine($"{objetivo.Nombre} ha recibido {dañoMagico} puntos de daño magico");
        Console.WriteLine($"A {objetivo.Nombre} le quedan {objetivo.Vida} puntos de vida");
    }
}
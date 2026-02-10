namespace jueguito.Personajes;
using jueguito.Core;

[InfoClase("El Bárbaro", "Proveniente de las tierras del norte, provisto de su armadura y su hacha. \nSu fuerza brutal y destreza en la batalla le hacen un guerrero temible.",100 ,35, 0, 30, 0)]
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
[InfoClase("El Hechicero", "Un erudito de las artes arcanas, poseedor de un poder mas alla de lo imaginable. \nFragil, pero capaz de desatar la destruccion sobre sus enemigos.", 100, 0, 50, 0, 0)]
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
[InfoClase("El Paladin", "Un soldado juramentado de los dioses, poseedor de un martillo sacro de batalla y un escudo bendito. \nEquilibrado en ataque y defensa, lucha sin temor, pues su fe lo guia.", 100, 15, 15, 18, 18)]
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
[InfoClase("El Vaquero", "Un bandido armado con dos revolvers de gran calibre y sin miedo a la muerte. \nNo cree en la magia ni en las armaduras pesadas, solo en la velocidad de sus armas.", 100, 50, 0, 0, 0)]
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
[InfoClase("La Valquiria", "Una guerrera divina descendida de los cielos para impartir justicia en la tierra. \nSu presencia impone orden y castiga a quienes osan usar magia oscura.", 100, 0, 35, 0, 30)]
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
        DescripcionDeAtaqueCritico = "desciende con la furia de los cielos y ataca el alma de";
    }
}


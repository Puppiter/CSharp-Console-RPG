using jueguito.Personajes;

namespace jueguito.Jefes;

public class JefeAntiguaGorgona : Personaje
{
    public JefeAntiguaGorgona() : base("AntiguaGorgona")
    {
        Nombre = "AntiguaGorgona";
        Vida = 400;
        Armadura = 20;
        ResistenciaMagica = 60;
    }
    public override void Atacar(Personaje objetivo)
    {
        Random rng = new Random();
        int ataqueCritico = rng.Next(0, 5);
        if (ataqueCritico == 4)
        {
            Console.WriteLine($"{Nombre} ataca: \n ¡Sus ojos brillan con un fulgor petrificante! ¡{objetivo.Nombre} siente su carne convertirse en piedra bajo su mirada! ");
            objetivo.RecibirDañoMagico(80);
        }
        else
        {
            Console.WriteLine($"{Nombre} ataca: \n Las serpientes de su cabeza se lanzan hacia adelante, mordiendo con colmillos venenosos a {objetivo.Nombre}");
            objetivo.RecibirDañoMagico(40);
        }
        VidaActual(objetivo);
    }
}
public class JefeSeñorDeLosGigantes : Personaje
{
    public JefeSeñorDeLosGigantes() : base("SeñorDeLosGigantes")
    {
        Nombre = "SeñorDeLosGigantes";
        Vida = 400;
        Armadura = 0;
        ResistenciaMagica = 80;
    }
    public override void Atacar(Personaje objetivo)
    {
        Random rng = new Random();
        int ataqueCritico = rng.Next(0, 5);
        if (ataqueCritico == 4)
        {
            Console.WriteLine($"{Nombre} Ruge con furia, levanta su enorme pie y lo deja caer con todo el peso de una montaña sobre {objetivo.Nombre}");
            objetivo.RecibirDañoFisico(80);
        }
        else
        {
            Console.WriteLine($"{Nombre} ataca: \n Lanza un puñetazo torpe pero masivo que hace temblar el suelo bajo los pies de {objetivo.Nombre}");
            objetivo.RecibirDañoFisico(40);
        }
        VidaActual(objetivo);
    }
}
public class JefeRenacidoReyDeHierro : Personaje
{
    public JefeRenacidoReyDeHierro() : base("Renacido Rey del Hierro")
    {
        Nombre = "Renacido Rey del Hierro";
        Vida = 400;
        Armadura = 40;
        ResistenciaMagica = 40;
    }
    public override void Atacar(Personaje objetivo)
    {
        Random rng = new Random();
        int ataqueCritico = rng.Next(0, 5);
        if (ataqueCritico == 4)
        {
            Console.WriteLine($"{Nombre} ataca: \n¡Las grietas de su armadura estallan en llamas! ¡Embiste con una estocada de acero fundido a {objetivo.Nombre}!");
            objetivo.RecibirDañoFisico(40);
            objetivo.RecibirDañoMagico(40);
        }
        else
        {
            Console.WriteLine($"{Nombre} Blande su espadón maldito en un arco letal, buscando partirte en dos {objetivo.Nombre}");
            objetivo.RecibirDañoFisico(20);
            objetivo.RecibirDañoMagico(20);
        }
        VidaActual(objetivo);
    }
}

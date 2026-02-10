using jueguito.Personajes;

namespace jueguito.Jefes;

public class JefeAntiguaGorgona : Personaje
{
    public JefeAntiguaGorgona() : base("AntiguaGorgona")
    {
        Nombre = "AntiguaGorgona";
        Vida = 400;
        DañoFisico = 0;
        DañoMagico = 35;
        Armadura = 20;
        ResistenciaMagica = 60;
        DescripcionDeAtaque = "ataca: \n Las serpientes de su cabeza se lanzan hacia adelante, mordiendo con colmillos venenosos a";
        DescripcionDeAtaqueCritico =  "¡Sus ojos brillan con un fulgor petrificante! Esta convirtiendo tu carne en piedra";
    }
}
public class JefeSeñorDeLosGigantes : Personaje
{
    public JefeSeñorDeLosGigantes() : base("SeñorDeLosGigantes")
    {
        Nombre = "SeñorDeLosGigantes";
        Vida = 400;
        DañoFisico = 0;
        DañoMagico = 35;
        Armadura = 0;
        ResistenciaMagica = 80;
        DescripcionDeAtaque = "ataca: \n Lanza un puñetazo torpe pero masivo que hace temblar el suelo bajo los pies de";
        DescripcionDeAtaqueCritico =  "Ruge con furia, levanta su enorme pie y lo deja caer con todo el peso de una montaña sobre";
    }
}
public class JefeRenacidoReyDeHierro : Personaje
{
    public JefeRenacidoReyDeHierro() : base("Renacido Rey del Hierro")
    {
        Nombre = "Renacido Rey del Hierro";
        Vida = 400;
        DañoFisico = 0;
        DañoMagico = 35;
        Armadura = 40;
        ResistenciaMagica = 40;
        DescripcionDeAtaque = "Blande su espadón maldito en un arco letal, buscando partirte en dos";
        DescripcionDeAtaqueCritico =  "¡Las grietas de su armadura estallan en llamas! ¡Embiste con una estocada de acero fundido a";
    }
}

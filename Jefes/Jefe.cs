using jueguito.Personajes;
using jueguito.Core;
namespace jueguito.Jefes;

[InfoClase("La Antigua Gorgona", "Una monstruosidad de tiempos olvidados con serpientes por cabello. \nSu mirada es capaz convierte la carne en piedra y el valor en polvo.",400, 0, 40, 10, 60 )]
public class JefeAntiguaGorgona : Personaje
{
    public JefeAntiguaGorgona() : base("La Antigua Gorgona")
    {
        Nombre = "La Antigua Gorgona";
        Vida = 400;
        DañoFisico = 0;
        DañoMagico = 40;
        Armadura = 10;
        ResistenciaMagica = 60;
        DescripcionDeAtaque = "ataca: \n Las serpientes de su cabeza se lanzan hacia adelante, mordiendo con colmillos venenosos a";
        DescripcionDeAtaqueCritico =  "¡Sus ojos brillan con un fulgor petrificante! Esta convirtiendo tu carne en piedra";
    }
}
[InfoClase("El señor de los Gigantes", "Un coloso que hace temblar la tierra con cada paso. \nSu fuerza bruta es capaz de aplastar montañas y héroes por igual.",400, 40, 0, 60, 0)]
public class JefeSeñorDeLosGigantes : Personaje
{
    public JefeSeñorDeLosGigantes() : base("El Señor De Los Gigantes")
    {
        Nombre = "El Señor De Los Gigantes";
        Vida = 400;
        DañoFisico = 40;
        DañoMagico = 0;
        Armadura = 70;
        ResistenciaMagica = 0;
        DescripcionDeAtaque = "ataca: \n Lanza un puñetazo torpe pero masivo que hace temblar el suelo bajo los pies de";
        DescripcionDeAtaqueCritico =  "Ruge con furia, levanta su enorme pie y lo deja caer con todo el peso de una montaña sobre";
    }
}
[InfoClase("El Renacido Rey del Hierro", "Un tirano envuelto en una armadura fundida con su propia piel. \nHa vuelto de la muerte, más duro, ardiente y cruel que nunca.", 400, 20, 20, 35, 35)]
public class JefeRenacidoReyDeHierro : Personaje
{
    public JefeRenacidoReyDeHierro() : base("El Renacido Rey del Hierro")
    {
        Nombre = "El Renacido Rey del Hierro";
        Vida = 400;
        DañoFisico = 20;
        DañoMagico = 20;
        Armadura = 40;
        ResistenciaMagica = 40;
        DescripcionDeAtaque = "Blande su espadón maldito en un arco letal, buscando partirte en dos";
        DescripcionDeAtaqueCritico =  "¡Las grietas de su armadura estallan en llamas! ¡Embiste con una estocada de acero fundido a";
    }
}

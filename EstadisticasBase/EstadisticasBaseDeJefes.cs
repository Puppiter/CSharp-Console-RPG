namespace jueguito.Jefes;

public record EstadisticasBaseDeJefes(string NombreDeClase, string DescripcionDeClase, int Vida, int DañoFisico, int DañoMagico, int Armadura, int ResistenciaMagica, string DescripcionDeAtaque, string DescripcionDeAtaqueCritico): IEstadisticasBase;

public enum ClaseDeJefe
{
    AntiguaGorgona,
    SeñorDeLosGigantes,
    RenacidoReyDelHierro

}

public static class InformacionDeClasesDeJefes
{
    public static readonly Dictionary<ClaseDeJefe, EstadisticasBaseDeJefes> registroDeClasesDeJefes = new()
    {
        {
            ClaseDeJefe.AntiguaGorgona,
            new EstadisticasBaseDeJefes(
                NombreDeClase : "La Antigua Gorgona",
                DescripcionDeClase : "Una monstruosidad de tiempos olvidados con serpientes por cabello. \nSu mirada es capaz convierte la carne en piedra y el valor en polvo.",
                Vida : 400,
                DañoFisico : 0,
                DañoMagico : 40,
                Armadura : 10,
                ResistenciaMagica : 60,
                DescripcionDeAtaque : "ataca: \n Las serpientes de su cabeza se lanzan hacia adelante, mordiendo con colmillos venenosos a",
                DescripcionDeAtaqueCritico : "¡Sus ojos brillan con un fulgor petrificante! Esta convirtiendo tu carne en piedra"

            )
        },
        {
                        ClaseDeJefe.SeñorDeLosGigantes,
            new EstadisticasBaseDeJefes(
                NombreDeClase : "El señor de los Gigantes",
                DescripcionDeClase : "Un coloso que hace temblar la tierra con cada paso. \nSu fuerza bruta es capaz de aplastar montañas y héroes por igual.",
                Vida : 400,
                DañoFisico : 40,
                DañoMagico : 0,
                Armadura : 60,
                ResistenciaMagica : 0,
                DescripcionDeAtaque : "ataca: \n Lanza un puñetazo torpe pero masivo que hace temblar el suelo bajo los pies de",
                DescripcionDeAtaqueCritico : "Ruge con furia, levanta su enorme pie y lo deja caer con todo el peso de una montaña sobre")
        },
        {
                        ClaseDeJefe.RenacidoReyDelHierro,
            new EstadisticasBaseDeJefes(
                NombreDeClase : "El Renacido Rey del Hierro",
                DescripcionDeClase : "Un tirano envuelto en una armadura fundida con su propia piel. \nHa vuelto de la muerte, más duro, ardiente y cruel que nunca.",
                Vida : 400,
                DañoFisico : 20,
                DañoMagico : 20,
                Armadura : 35,
                ResistenciaMagica : 35,
                DescripcionDeAtaque : "Blande su espadón maldito en un arco letal, buscando partirte en dos",
                DescripcionDeAtaqueCritico : "¡Las grietas de su armadura estallan en llamas! ¡Embiste con una estocada de acero fundido a")
        }
    };
}
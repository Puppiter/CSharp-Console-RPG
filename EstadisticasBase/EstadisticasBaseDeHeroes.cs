namespace jueguito.Personajes;

public record EstadisticasBaseDeHeroes (string NombreDeClase, string DescripcionDeClase, int Vida, int DañoFisico, int DañoMagico, int Armadura, int ResistenciaMagica, string DescripcionDeAtaque, string DescripcionDeAtaqueCritico) : IEstadisticasBase;

public enum ClaseDeHeroe
{
    Barbaro,
    Hechicero,
    Paladin,
    Vaquero,
    Valquiria

}

public static class InformacionDeClasesDeHeroes
{
    public static readonly Dictionary<ClaseDeHeroe, EstadisticasBaseDeHeroes> registroDeClasesDeHeroes = new()
    {
        {
            ClaseDeHeroe.Barbaro,
            new EstadisticasBaseDeHeroes(NombreDeClase: "Barbaro",
             DescripcionDeClase: "Proveniente de las tierras del norte, provisto de su armadura y su hacha. \nSu fuerza brutal y destreza en la batalla le hacen un guerrero temible.",
             Vida: 100,
              DañoFisico: 35,
               DañoMagico: 0,
                Armadura: 30,
                 ResistenciaMagica: 0,
                  DescripcionDeAtaque: "lanza un ataque brutal con su Hacha de Batalla sobre",
                   DescripcionDeAtaqueCritico: "entra en un frenesí asesino y descarga un golpe devastador sobre")
        },
        {
            ClaseDeHeroe.Hechicero,
            new EstadisticasBaseDeHeroes(NombreDeClase: "Hechicero",
            DescripcionDeClase: "Un erudito de las artes arcanas, poseedor de un poder mas alla de lo imaginable. \nFragil, pero capaz de desatar la destruccion sobre sus enemigos.",
             Vida: 100,
              DañoFisico: 0,
               DañoMagico: 50,
                Armadura: 0,
                 ResistenciaMagica: 0,
                  DescripcionDeAtaque: "castea una poderosa bola de fuego hacia",
                   DescripcionDeAtaqueCritico: "canaliza el poder del cosmos en una explosión de energía pura contra")
        },
        {
            ClaseDeHeroe.Paladin,
            new EstadisticasBaseDeHeroes(NombreDeClase: "Paladin",
            DescripcionDeClase: "Un soldado juramentado de los dioses, poseedor de un martillo sacro de batalla y un escudo bendito. \nEquilibrado en ataque y defensa, lucha sin temor, pues su fe lo guia.",
             Vida: 100,
              DañoFisico: 15,
               DañoMagico: 15,
               Armadura: 18,
                ResistenciaMagica: 18,
                 DescripcionDeAtaque: "arremete con su martillo sacro contra",
                  DescripcionDeAtaqueCritico: "invoca la justicia divina y aplasta con un impacto sagrado a")
        },
        {
            ClaseDeHeroe.Vaquero,
            new EstadisticasBaseDeHeroes(NombreDeClase: "Vaquero",
            DescripcionDeClase: "Un bandido armado con dos revolvers de gran calibre y sin miedo a la muerte. \nNo cree en la magia ni en las armaduras pesadas, solo en la velocidad de sus armas.",
             Vida: 100,
              DañoFisico: 50,
               DañoMagico: 0,
                Armadura: 0,
                 ResistenciaMagica: 0,
                  DescripcionDeAtaque: "vacio el cargador de su revolver sobre",
                   DescripcionDeAtaqueCritico: "ajusta su sombrero y vacía el tambor de su revolver con precisión quirúrgica en")
        },
        {
            ClaseDeHeroe.Valquiria,
            new EstadisticasBaseDeHeroes(NombreDeClase: "Valquiria",
            DescripcionDeClase: "Una guerrera divina descendida de los cielos para impartir justicia en la tierra. \nSu presencia impone orden y castiga a quienes osan usar magia oscura.",
             Vida: 100,
              DañoFisico: 0,
               DañoMagico: 35,
                Armadura: 0,
                 ResistenciaMagica: 30,
                  DescripcionDeAtaque: "embiste con su lanza a",
                   DescripcionDeAtaqueCritico: "desciende con la furia de los cielos y ataca el alma de")
        }
    };
}
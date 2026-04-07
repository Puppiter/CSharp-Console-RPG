public interface IEstadisticasBase
{
    string NombreDeClase {get;}

    string DescripcionDeClase {get;}
    int Vida { get; }
    int DañoFisico { get; }
    int DañoMagico { get; }
    int Armadura { get; }
    int ResistenciaMagica { get; }
    string DescripcionDeAtaque { get; }
    string DescripcionDeAtaqueCritico { get; }
}
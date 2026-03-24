public interface IEstadisticasBase
{
    int Vida { get; }
    int DañoFisico { get; }
    int DañoMagico { get; }
    int Armadura { get; }
    int ResistenciaMagica { get; }
    string DescripcionDeAtaque { get; }
    string DescripcionDeAtaqueCritico { get; }
}
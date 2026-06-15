namespace jueguito.UI;
using jueguito.Personajes;


public interface IInputService
{
    public string SolicitarNombreDelHeroe();

    public int SeleccionarInt(int maximo, int minimo);

    public bool SolicitarConfirmacion(string mensaje);

    public int SeleccionarClaseDelHeroe(IEnumerable<IEstadisticasBase> listaDeEstadisticas);

    public int SeleccionarClaseDelJefe(IEnumerable<IEstadisticasBase> listaDeEstadisticas);
    
}
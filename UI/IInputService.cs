namespace jueguito.UI;
using jueguito.Personajes;


public interface IInputService
{
    public string SolicitarNombreDelHeroe();

    public Type SeleccionarDeDiccionario(Dictionary<int, Type> opciones);

    
}
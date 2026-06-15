namespace jueguito.UI;

public interface IMessageService
{
    public void MostrarMensaje(string mensaje);

    public void MensajeDeAtaque(int dañoMagico, int dañoFisico, int vidaDelObjetivo, string nombreDelAtacante, string nombreDelObjetivo, string descripcionDeAtaque);

    public void MensajeDeHeroeMuerto(string nombreDelHeroe);

    public void MensajeDeNuevoMiembro(string nombreDelHeroe);

    public void MensajeDeGrupoDerrotado();

    public void MensajeDeApertura();

    public void MensajeDeJefeDerrotado(string nombreDelJefe);

    public void MostrarPartyYJefe(List<string> nombresDelGrupoDeHeroes,List<string> clasesDelGrupoDeHeroes, string nombreDelJefe);

    public void TurnoDeAtaque(string nombreDelJefe);

    public void TurnoDeDefensa(string nombreDelJefe);

    public void MostrarInformacionDeJefes(IEnumerable<IEstadisticasBase> listaDeClasesDeJefes);

    public void MostrarInformacionDeHeroes(IEnumerable<IEstadisticasBase> listaDeClasesDeHeroes);



}
namespace jueguito.UI;
public interface IMessageService
{
    public void MostrarMensaje(string mensaje);    
    
    public void MensajeDeAtaque(int dañoMagico, int dañoFisico, int vidaDelObjetivo, string nombreDelAtacante, string nombreDelObjetivo, string descripcionDeAtaque);

    public void MensajeDeHeroeMuerto(string nombreDelHeroe);

    public void MensajeDeGrupoDerrotado();

    public void MensajeDeApertura();

    public void MensajeDeJefeDerrotado();

    public void MostrarPartyYJefe();

    public void TurnoDeAtaque();

    public void TurnoDeDefensa();

    public void MostrarInformacionDeJefes();

    public void MostrarInformacionDeHeroes();



}
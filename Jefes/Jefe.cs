using jueguito.Personajes;
using jueguito.Core;
using jueguito.Jefes;
namespace jueguito.Jefes;

public class JefeAntiguaGorgona : Personaje
{
    public JefeAntiguaGorgona() : base("La Antigua Gorgona", InformacionDeClasesDeJefes.registroDeClasesDeJefes[ClaseDeJefe.AntiguaGorgona])
    {
    }
}
public class JefeSeñorDeLosGigantes : Personaje
{
    public JefeSeñorDeLosGigantes() : base("El Señor De Los Gigantes", InformacionDeClasesDeJefes.registroDeClasesDeJefes[ClaseDeJefe.SeñorDeLosGigantes])
    {
    }
}
public class JefeRenacidoReyDeHierro : Personaje
{
    public JefeRenacidoReyDeHierro() : base("El Renacido Rey del Hierro", InformacionDeClasesDeJefes.registroDeClasesDeJefes[ClaseDeJefe.RenacidoReyDelHierro])
    {
    }
}

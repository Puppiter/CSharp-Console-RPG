namespace jueguito.Personajes;
using jueguito.Core;
public class Barbaro : Personaje
{
    
    public Barbaro(string nombre) : base(nombre, InformacionDeClasesDeHeroes.registroDeClasesDeHeroes[ClaseDeHeroe.Barbaro])
    {
    }
}

public class Hechicero : Personaje
{
    public Hechicero(string nombre) : base(nombre, InformacionDeClasesDeHeroes.registroDeClasesDeHeroes[ClaseDeHeroe.Hechicero])
    {
    }
}
public class Paladin : Personaje
{
    public Paladin(string nombre) : base(nombre, InformacionDeClasesDeHeroes.registroDeClasesDeHeroes[ClaseDeHeroe.Paladin])
    {
    }
}
public class Vaquero : Personaje
{
    public Vaquero(string nombre) : base(nombre, InformacionDeClasesDeHeroes.registroDeClasesDeHeroes[ClaseDeHeroe.Vaquero])
    {
    }
}
public class Valquiria : Personaje
{
    public Valquiria(string nombre) : base(nombre, InformacionDeClasesDeHeroes.registroDeClasesDeHeroes[ClaseDeHeroe.Valquiria])
    {
    }
}


using jueguito.Personajes;
using jueguito.Jefes;
using jueguito.Core;
namespace jueguito.Creador
{
    public static class Creadora
    {
    public static Personaje CrearPersonaje()
        {
            string? readResult;
            string nombreDelHeroe = "";
            int i = 0;
            
            Console.WriteLine("Escribe el nombre del heroe");
            readResult = Console.ReadLine();
            if (readResult != null)
            { nombreDelHeroe = readResult.ToLower().Trim(); }
            

            do
            {
                Console.WriteLine("Selecciona la clase del heroe");
                Console.WriteLine("1. Barbaro");
                Console.WriteLine("2. Hechicero");
                Console.WriteLine("3. Paladin");
                Console.WriteLine("4. Vaquero");
                Console.WriteLine("5. Valquiria");

                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    bool validInput = int.TryParse(readResult.Trim(), out i);
                    if (validInput)
                    {
                        if (i > 0 && i < 6)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Por favor seleccione una de las 5 clases disponibles");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor seleccione una de las 5 clases disponibles");
                    }
                }
            } while (true);
            return i switch
            {
                1 => new Barbaro(nombreDelHeroe + " el barbaro"),
                2 => new Hechicero(nombreDelHeroe + " el hechicero"),
                3 => new Paladin(nombreDelHeroe + " el paladin"),
                4 => new Vaquero(nombreDelHeroe + " el vaquero"),
                5 => new Valquiria(nombreDelHeroe + " la valquiria"),
                _ => throw new Exception("The Game, respiracion automatica desactivada")
            };
        }
        public static List<Personaje> CrearGrupoDeHeroes()
        {
            List<Personaje> grupoDeHeroes = new List<Personaje>();

            Console.Clear();
            Console.WriteLine("Es hora de elegir los heroes para esta aventura");
            Console.WriteLine("Tienes 5 clases de heroes disponibles");
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("Barbaro: \nProveniente de las tierras del norte, provisto de su armadura y su hacha. \nSu fuerza brutal y destreza en la batalla le hacen un guerrero temible.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño Fisico=35\n Daño magico=0\n Armadura=30\n Resistencia magica=0");
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("Hechicero: \nUn erudito de las artes arcanas, poseedor de un poder mas alla de lo imaginable. \nFragil, pero capaz de desatar la destruccion sobre sus enemigos.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño fisico=0\n Daño magico=50\n Armadura=0\n Resistencia magica=0");
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("Paladin: \nUn soldado juramentado de los dioses, poseedor de un martillo sacro de batalla y un escudo bendito. \nEquilibrado en ataque y defensa, lucha sin temor, pues su fe lo guia.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño fisico=15\n Daño magico=15\n Armadura=18\n Resistencia magica=18");
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("Vaquero: \nUn bandido armado con dos revolvers de gran calibre y sin miedo a la muerte. \nNo cree en la magia ni en las armaduras pesadas, solo en la velocidad de sus armas.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño fisico=50\n Daño magico=0\n Armadura=0\n Resistencia magica=0");
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("Valquiria:\nUna guerrera divina descendida de los cielos para impartir justicia en la tierra. \nSu presencia impone orden y castiga a quienes osan usar magia oscura.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño fisico=0\n Daño magico=35\n Armadura=0\n Resistencia magica=30");
            Herramientas.LimpiezaDeConsola();

            do
            {
                Personaje heroeNuevo = Creadora.CrearPersonaje();
                Console.WriteLine($"{heroeNuevo.Nombre} se ha unido al grupo de heroes.");
                Herramientas.LimpiezaDeConsola();
                grupoDeHeroes.Add(heroeNuevo);
                if (grupoDeHeroes.Count == 3)
                {
                    break;
                }
            } while (true);
            return grupoDeHeroes;

        }
        public static Personaje SeleccionarJefe()
        {
            string? readResult;
            int i = 0;
            Console.Clear();
            Console.WriteLine("Llego el momento de elegir el enemigo para esta aventura");
            Console.WriteLine("Tienes 3 grandes jefes para elegir:");
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("La Antigua Gorgona, una monstruosidad de tiempos olvidados con serpientes por cabello. \nSu mirada es capaz convierte la carne en piedra y el valor en polvo.");
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("El Señor de los Gigantes, un coloso que hace temblar la tierra con cada paso. \nSu fuerza bruta es capaz de aplastar montañas y héroes por igual.");
            Herramientas.LimpiezaDeConsola();
            Console.WriteLine("El Renacido Rey del Hierro, un tirano envuelto en una armadura fundida con su propia piel. \nHa vuelto de la muerte, más duro, ardiente y cruel que nunca.");
            Herramientas.LimpiezaDeConsola();
            do
            {
                Console.WriteLine("Selecciona el jefe que desees enfrentar:");
                Console.WriteLine("1. La Antigua Gorgona");
                Console.WriteLine("2. El Señor de los Gigantes");
                Console.WriteLine("3. El Renacido Rey del Hierro");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    bool validInput = int.TryParse(readResult.Trim(), out i);
                    if (validInput && i < 4 && i > 0)
                    {
                        return i switch
                        {
                            1 => new JefeAntiguaGorgona(),
                            2 => new JefeSeñorDeLosGigantes(),
                            3 => new JefeRenacidoReyDeHierro(),
                            _ => throw new Exception("The Game, respiracion automatica desactivada")
                        };
                    }
                    else
                    {
                        Console.WriteLine("Por favor, elige una de las opciones.");
                    }
                }
            } while (true);

        }
    }
}
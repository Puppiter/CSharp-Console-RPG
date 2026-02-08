using jueguito.Personajes;
namespace jueguito.Core
{
    using System.Collections.Generic;
    using System.Timers;
    using jueguito.Jefes;

    public class Juego
    {
        public Juego()
        {
        }

        public void IniciarJuego()
        {
            Console.WriteLine("Bienvenido al Juego, en este juego crearas un grupo de 3 heroes para enfrentarte a uno de los temibles jefes.");
            Console.WriteLine("El combate es simple, eliges a uno de los heroes para atacar, y a uno para cubrir.");
            Console.WriteLine("El jefe a su vez atacara, pero hay una pequeña probabilidad de que ignore a quien elegiste para recibir el golpe, y golpee a otro heroe");
            Console.WriteLine("¡Comencemos!");
            Console.ReadLine();
            Console.Clear();
            List<Personaje> grupoDeHeroes = CrearGrupoDeHeroes();
            Personaje jefe = SeleccionarJefe();
            Console.WriteLine("Tu grupo de heroes se conforma por");
            foreach (Personaje heroeActual in grupoDeHeroes)
            {
                Console.WriteLine(heroeActual.Nombre);
            }
            Console.WriteLine($"Y han de enfrentarse a {jefe.Nombre}");
        }

        public void LoopDeJuego(List<Personaje> grupoDeHeroes, Personaje jefe)
        {
            do
            {
                
                VerificarGrupoDeHeroes(grupoDeHeroes);
                if (grupoDeHeroes.Count == 0)
                {
                    break;
                }
                if(VerificarJefe(jefe))
                {
                    break;
                }

            } while (true);
        }

        public bool VerificarJefe(Personaje jefe)
        {
            if (jefe.Vida < 1)
            {
                Console.WriteLine($"Pese a su poder {jefe.Nombre} ha caido derrotado por el grupo de heroes.");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SeleccionarAccion(List<Personaje> grupoDeHeroes, Personaje jefe)
        {
            int j = 9;
            string? readResult;
            Console.WriteLine($"Debes decidir que hacer en este turno, que heroe atacara, y cual intentara recibir el ataque de {jefe.Nombre}");
            do
            {
            Console.WriteLine("¿Quien atacara?");
            for(int i = grupoDeHeroes.Count; i >= 0; i--)
            {
                Console.WriteLine($"{i}. {grupoDeHeroes[i].Nombre}");
            }
            readResult = Console.ReadLine();
            if(readResult != null)
            {
                bool validInput = int.TryParse(readResult.Trim(), out j);
            
            }
            } while(true);
        }
        public List<Personaje> VerificarGrupoDeHeroes(List<Personaje> grupoDeHeroes)
        {
            for (int i = grupoDeHeroes.Count -1;i >= 0; i-- )
            {
                if (grupoDeHeroes[i].Vida < 1)
                {
                    Console.WriteLine($"Oh no, {grupoDeHeroes[i].Nombre} ha caido derrotado.");
                    grupoDeHeroes.RemoveAt(i);
                }
            }
            if(grupoDeHeroes.Count == 0)
            {
                Console.WriteLine("El grupo de heroes ha sido derrotado.");
            }
           return grupoDeHeroes;
        }




        public Personaje SeleccionarJefe()
        {
            string? readResult;
            int i = 0;
            Console.Clear();
            Console.WriteLine("Llego el momento de elegir el enemigo para esta aventura");
            Console.WriteLine("Tienes 3 grandes jefes para elegir:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("La Antigua Gorgona, una monstruosidad de tiempos olvidados con serpientes por cabello. \nSu mirada es capaz convierte la carne en piedra y el valor en polvo.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("El Señor de los Gigantes, un coloso que hace temblar la tierra con cada paso. \nSu fuerza bruta es capaz de aplastar montañas y héroes por igual.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("El Renacido Rey del Hierro, un tirano envuelto en una armadura fundida con su propia piel. \nHa vuelto de la muerte, más duro, ardiente y cruel que nunca.");
            Console.ReadLine();
            Console.Clear();
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
                        Console.WriteLine("Please select one option");
                    }
                }
            } while (true);

        }

        public List<Personaje> CrearGrupoDeHeroes()
        {
            List<Personaje> grupoDeHeroes = new List<Personaje>();

            Console.Clear();
            Console.WriteLine("Es hora de elegir los heroes para esta aventura");
            Console.WriteLine("Tienes 5 clases de heroes disponibles");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Barbaro: \nProveniente de las tierras del norte, provisto de su armadura y su hacha. \nSu fuerza brutal y destreza en la batalla le hacen un guerrero temible.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño Fisico=35\n Daño magico=0\n Armadura=30\n Resistencia magica=0");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hechicero: \nUn erudito de las artes arcanas, poseedor de un poder mas alla de lo imaginable. \nFragil, pero capaz de desatar la destruccion sobre sus enemigos.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño fisico=0\n Daño magico=50\n Armadura=0\n Resistencia magica=0");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Paladin: \nUn soldado juramentado de los dioses, poseedor de un martillo sacro de batalla y un escudo bendito. \nEquilibrado en ataque y defensa, lucha sin temor, pues su fe lo guia.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño fisico=15\n Daño magico=15\n Armadura=18\n Resistencia magica=18");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Vaquero: \nUn bandido armado con dos revolvers de gran calibre y sin miedo a la muerte. \nNo cree en la magia ni en las armaduras pesadas, solo en la velocidad de sus armas.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño fisico=50\n Daño magico=0\n Armadura=0\n Resistencia magica=0");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Valquiria:\nUna guerrera divina descendida de los cielos para impartir justicia en la tierra. \nSu presencia impone orden y castiga a quienes osan usar magia oscura.");
            Console.WriteLine("Estadisticas:\n Vida=100\n Daño fisico=0\n Daño magico=35\n Armadura=0\n Resistencia magica=30");

            do
            {
                Personaje heroeNuevo = CrearPersonaje();
                grupoDeHeroes.Add(heroeNuevo);
                if (grupoDeHeroes.Count == 3)
                {
                    break;
                }
            } while (true);
            return grupoDeHeroes;

        }



        public Personaje CrearPersonaje()
        {
            string? readResult;
            string nombreDelHeroe = "";
            int i = 0;

            Console.Clear();
            Console.WriteLine("Escribe el nombre del heroe");
            readResult = Console.ReadLine();
            if (readResult != null)
            { nombreDelHeroe = readResult.ToLower().Trim(); }
            Console.Clear();

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
                1 => new Barbaro(nombreDelHeroe),
                2 => new Hechicero(nombreDelHeroe),
                3 => new Paladin(nombreDelHeroe),
                4 => new Vaquero(nombreDelHeroe),
                5 => new Valquiria(nombreDelHeroe),
                _ => throw new Exception("The Game, respiracion automatica desactivada")
            };
        }


    }
}

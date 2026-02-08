using jueguito.Personajes;
using System.Collections.Generic;
using System.Timers;
using jueguito.Jefes;
namespace jueguito.Core
{
    public static class Fabrica
    {
        public static Personaje CrearPersonaje()
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

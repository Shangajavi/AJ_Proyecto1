namespace AJ_Proyecto1;

class Program
{
    static Random rng = new Random();
    
    static void Main(string[] args)
    {
        string mensaje, comentarios, claseJugador;
        int numPersonajes;
        bool comment, valido;
        Personaje jugador;
        Partida partida;
        List<Personaje> listaPersonajes = new List<Personaje>();

        do
        {
            mensaje = GetConsoleMessage("### Bienvenido a NBAttleRoyale ###\n¿Quieres jugar? (Y/N)").ToUpper();

            if (mensaje != "Y" && mensaje != "N")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Escribe Y para sí o N para no. No hay tercera opción.");
                Console.ResetColor();
            }

        } while (mensaje != "Y" && mensaje != "N");

        Console.Clear();

        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Elige cuántos personajes participarán en esta masacre (10-100): ");
            Console.ResetColor();

            valido = int.TryParse(Console.ReadLine(), out numPersonajes);

            if (!valido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eso no es un número. Inténtalo otra vez.");
                Console.ResetColor();
            }
            else if (numPersonajes < 10 || numPersonajes > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El número debe estar entre 10 y 100. No te emociones.");
                Console.ResetColor();
            }

        } while (!valido || numPersonajes < 10 || numPersonajes > 100);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Número aceptado: " + numPersonajes);
        Console.ResetColor();

        Thread.Sleep(1000);
        Console.Clear();

        if (mensaje == "Y")
        {
            do
            {
                comentarios = GetConsoleMessage("¿Quieres ver todas las acciones y peleas de los demás personajes? (Y/N)").ToUpper();

                if (comentarios != "Y" && comentarios != "N")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Responde con Y o N. Prometo que solo hay dos opciones.");
                    Console.ResetColor();
                }

            } while (comentarios != "Y" && comentarios != "N");

            Console.Clear();

            comment = comentarios == "Y";

            do
            {
                claseJugador = GetConsoleMessage(
                    "¿Qué clase quieres jugar?\n" +
                    "Bárbaro (B)\n" +
                    "Hechicero (S)\n" +
                    "Mago (M)\n" +
                    "Druida (D)\n" +
                    "Pícaro (R)"
                ).ToUpper();

            } while (claseJugador != "B" && claseJugador != "S" && claseJugador != "M" && claseJugador != "D" && claseJugador != "R");

            string nombre = GetConsoleMessage("¿Cuál es tu nombre, futuro campeón (o futura víctima)?: ");

            switch (claseJugador)
            {
                case "B":
                    jugador = new Barbaro(nombre, true, comment);
                    listaPersonajes.Add(jugador);
                    break;

                case "S":
                    jugador = new Brujo(nombre, true, comment);
                    listaPersonajes.Add(jugador);
                    break;

                case "M":
                    jugador = new Mago(nombre, true, comment);
                    listaPersonajes.Add(jugador);
                    break;

                case "D":
                    jugador = new Druida(nombre, true, comment);
                    listaPersonajes.Add(jugador);
                    break;

                default:
                    jugador = new Picaro(nombre, true, comment);
                    listaPersonajes.Add(jugador);
                    break;
            }

            Console.Clear();
        }

        StartGameList(numPersonajes, listaPersonajes);

        Thread.Sleep(5000);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("### QUE COMIENCE LA BATALLA ###");
        Console.ResetColor();

        partida = new Partida(numPersonajes);
        partida.StartGame(listaPersonajes);
    }


    private static string GetConsoleMessage(string mensaje)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(mensaje);
        Console.ResetColor();

        return Console.ReadLine();
    }


    private static void StartGameList(int numPersonajes, List<Personaje> listaPersonajes)
    {
        Personaje npc;

        int barbaros = 0;
        int hechiceros = 0;
        int magos = 0;
        int druidas = 0;
        int picaros = 0;

        if (listaPersonajes.Count == 1)
        {
            numPersonajes -= 1;
        }

        for (int i = 0; i < numPersonajes; i++)
        {
            int numClase = rng.Next(1, 6);

            switch (numClase)
            {
                case 1:
                    npc = new Barbaro("Bárbaro " + barbaros++);
                    listaPersonajes.Add(npc);
                    break;

                case 2:
                    npc = new Brujo("Hechicero " + hechiceros++);
                    listaPersonajes.Add(npc);
                    break;

                case 3:
                    npc = new Mago("Mago " + magos++);
                    listaPersonajes.Add(npc);
                    break;

                case 4:
                    npc = new Druida("Druida " + druidas++);
                    listaPersonajes.Add(npc);
                    break;

                default:
                    npc = new Picaro("Pícaro " + picaros++);
                    listaPersonajes.Add(npc);
                    break;
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("Participantes generados:");
        Console.WriteLine("Bárbaros: " + barbaros);
        Console.WriteLine("Hechiceros: " + hechiceros);
        Console.WriteLine("Magos: " + magos);
        Console.WriteLine("Druidas: " + druidas);
        Console.WriteLine("Pícaros: " + picaros);
        Console.WriteLine("Total de combatientes: " + listaPersonajes.Count);

        Console.ResetColor();
    }
}
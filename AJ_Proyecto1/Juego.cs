namespace AJ_Proyecto1;

public class Juego
{
    Random rng = new Random();

    public void GameStarted()
    {
        string mensaje, comentarios, claseJugador;
        int numPersonajes;
        bool comment, valido;
        Personaje jugador;
        Partida partida;
        List<Personaje> listaPersonajes = new List<Personaje>();

        do
        {
            mensaje = GetConsoleMessage("### Bienvenido a NBAttleRoyale ###\n¿Quieres jugar?" +
                                        " (Y/N)  (Q para salir)").ToUpper();

            if (mensaje != "Y" && mensaje != "N" && mensaje != "Q")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Escribe Y para sí, N para no o Q para salir. No hay más opciones.");
                Console.ResetColor();
            }

            if (mensaje == "Q") Quitting(true);

        } while (mensaje != "Y" && mensaje != "N" && mensaje != "Q");

        Console.Clear();


        do
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Elige cuántos personajes participarán en esta batalla (10-100): ");
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
                Console.WriteLine("El número tiene que estar entre 10 y 100. No te emociones.");
                Console.ResetColor();
            }

        }
        while (!valido || numPersonajes < 10 || numPersonajes > 100);


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Número aceptado: " + numPersonajes);
        Console.ResetColor();

        Thread.Sleep(1000);
        Console.Clear();


        if (mensaje == "Y")
        {
            do
            {
                comentarios = GetConsoleMessage("¿Quieres ver todas las acciones y combates de los demás personajes?" +
                                                " (Y/N) (Q para salir)").ToUpper();

                if (comentarios != "Y" && comentarios != "N" && comentarios != "Q")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Responde con Y, N o Q. No es complicado.");
                    Console.ResetColor();
                }

                if (comentarios == "Q") Quitting(true);

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

            } while (claseJugador != "B" && claseJugador != "S" && claseJugador != "M"
                     && claseJugador != "D" && claseJugador != "R");


            string nombre = GetConsoleMessage("¿Cómo te llamas, valiente combatiente (o futura estadística)?: ");


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

        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("### QUE COMIENCE LA BATALLA ###");
        Console.ResetColor();


        partida = new Partida(numPersonajes);
        partida.StartGame(listaPersonajes);
    }


    private string GetConsoleMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);
        Console.ResetColor();

        return Console.ReadLine();
    }


    private void StartGameList(int numCharacters, List<Personaje> characterList)
    {
        Personaje npc;

        int barbaros = 0;
        int hechiceros = 0;
        int magos = 0;
        int druidas = 0;
        int picaros = 0;

        if (characterList.Count == 1)
        {
            numCharacters -= 1;
        }

        for (int i = 0; i < numCharacters; i++)
        {
            int numClass = rng.Next(1, 6);

            switch (numClass)
            {
                case 1:
                    npc = new Barbaro("Bárbaro " + barbaros++);
                    characterList.Add(npc);
                    break;

                case 2:
                    npc = new Brujo("Hechicero " + hechiceros++);
                    characterList.Add(npc);
                    break;

                case 3:
                    npc = new Mago("Mago " + magos++);
                    characterList.Add(npc);
                    break;

                case 4:
                    npc = new Druida("Druida " + druidas++);
                    characterList.Add(npc);
                    break;

                default:
                    npc = new Picaro("Pícaro " + picaros++);
                    characterList.Add(npc);
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
        Console.WriteLine("Total de combatientes: " + characterList.Count);

        Console.ResetColor();
    }


    private void Quitting(bool quit = false)
    {
        if (!quit)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Algo ha salido mal. Cerrando el programa antes de que empeore.");
            Console.ResetColor();

            Environment.Exit(0);
        }

        if (quit)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Saliendo del juego... Gracias por no morir demasiado.");
            Console.ResetColor();

            Environment.Exit(0);
        }
    }
}
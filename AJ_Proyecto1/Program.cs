namespace AJ_Proyecto1;


class Program
{
    static Random rng = new Random();
    
    static void Main(string[] args)
    {
        
        string message, comments, playerClass;
        int numCharacter;
        bool comment,valido;
        Personaje player;
        Partida game;
        List<Personaje> characterList = new List<Personaje>();
        
        do
        {
            message = GetConsoleMessage("### Welcome to NBAttleRoyale ### \n Do you wanna play? (Y/N)").ToUpper();;
            if(message != "Y" && message != "N") Console.WriteLine("Please, put Y(Yes) or N(No)");
        } while (message != "Y" && message != "N");
        Console.Clear();

        do
        {
            Console.Write("Pick a number of Characters on this game (10-100): ");
            valido = int.TryParse(Console.ReadLine(), out numCharacter);

            if (!valido)
                Console.WriteLine("You need to write a number.");
            else if (numCharacter < 10 || numCharacter > 100)
                Console.WriteLine("The number need to be between 10 and 100.");
        }
        while (!valido || numCharacter < 10 || numCharacter > 100);

        Console.WriteLine("Number Accepted: " + numCharacter);
        Thread.Sleep(1000);
        Console.Clear();
        
        if (message == "Y")
        {
            do
            {
                comments = GetConsoleMessage("Do you want to see the other actions and fights? (Y/N)").ToUpper();;
                if(comments != "Y" && comments != "N") Console.WriteLine("Please, put Y(Yes) or N(No)");
            } while (comments != "Y" && comments != "N");
            Console.Clear();

            if (comments == "Y") comment = true;
            else comment = false;
            do
            {
                playerClass = GetConsoleMessage("What class do you wanna play with? \n Barbarian (B) \n Sorcerer(S)" +
                                                " \n Mage(M) \n Druid(D) \n Rogue(R)").ToUpper();
            } while (playerClass != "B" && playerClass != "S" && playerClass != "M" && playerClass != "D" && playerClass != "R");

            string name = GetConsoleMessage("Whats your name?: ");
            
            switch (playerClass)
            {
                case "B":
                    player = new Barbaro(name, true, comment);
                    characterList.Add(player);
                    break;
                case "S":
                    player = new Brujo(name, true, comment);
                    characterList.Add(player);
                    break;
                case "M":
                    player = new Mago(name, true, comment);
                    characterList.Add(player);
                    break;
                case "D":
                    player = new Druida(name, true, comment);
                    characterList.Add(player);
                    break;
                default:
                    player = new Picaro(name, true, comment);
                    characterList.Add(player);
                    break;
            }
            Console.Clear();
        }
        
        StartGameList(numCharacter, characterList);
        Thread.Sleep(5000);
        Console.WriteLine("### LETS THIS GAME STARTED!! ###");
        game = new Partida(numCharacter);
        game.StartGame(characterList);
        

    }

    private static string GetConsoleMessage(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    private static void StartGameList(int numCharacters, List<Personaje> characterList)
    {
        Personaje npc;
        int barb = 0, sorc = 0, mage = 0, drui = 0, rogu = 0;
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
                    npc = new Barbaro("Barbarian"+ barb++);
                    characterList.Add(npc);
                    break;
                case 2:
                    npc = new Brujo("Sorcerer" + sorc++);
                    characterList.Add(npc);
                    break;
                case 3:
                    npc = new Mago("Mage" + mage++);
                    characterList.Add(npc);
                    break;
                case 4:
                    npc = new Druida("Druid" + drui ++);
                    characterList.Add(npc);
                    break;
                default:
                    npc = new Picaro("Rogue" + rogu++);
                    characterList.Add(npc);
                    break;
            }
        }
        
        Console.WriteLine("Barbarians: " + barb + " Sorcerer: " + sorc + " Mage: "
            + mage + " Druids: " + drui + " Rogues: " + rogu + ", Total characters: "+ characterList.Count);
    }
}
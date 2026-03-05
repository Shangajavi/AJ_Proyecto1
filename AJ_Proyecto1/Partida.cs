namespace AJ_Proyecto1;

public class Partida
{
    public int num_personajes;
    private Random rng = new Random();
    private Combate pelea = new Combate();

    public Partida(int num_personajes)
    {
        this.num_personajes = num_personajes;
    }

    public void StartGame(List<Personaje> characters)
    {
        pelea.Pelea(characters);
    }

    public void Events(List<Personaje> characters, int numberOfEvent)
    {
        // Protección general: si no hay personajes, no se puede hacer nada
        if (characters.Count == 0)
        {
            Console.WriteLine("No quedan personajes vivos.");
            return;
        }

        List<Personaje> theChosens = new List<Personaje>();

        switch (numberOfEvent)
        {
            // Zona 1 (Con el default)
            case 1:
                Console.WriteLine("Ha ocurrido una tormenta de arena en la zona 1, haciendo uno de daño a todos");
                ApplyDamageForAll(characters, 1);
                break;

            // Zona 2
            case 2:
                {
                    Personaje theChosenOne = GetRandomCharacter(characters);
                    Console.WriteLine($"{theChosenOne.nombre} se ha caído de morro en la zona 2, que tonto");
                    ApplyDamage(theChosenOne, characters, 2);

                    if (!characters.Contains(theChosenOne))
                        Console.WriteLine("El niño se ha escoñao (Sa matao paco)");
                }
                break;

            case 3:
                {
                    Personaje theChosenOne = GetRandomCharacter(characters);
                    Personaje theSecondOne = GetRandomCharacter(characters);

                    if (theChosenOne == theSecondOne)
                    {
                        Console.WriteLine($"{theChosenOne.nombre} se ha abrazado a sí mismo en la zona 2, que mono");
                    }
                    else
                    {
                        Console.WriteLine($"{theChosenOne.nombre} ha abrazado a {theSecondOne.nombre} en la zona 2, que bonito");
                    }
                }
                break;

            // Zona 3
            case 4:
                {
                    PutCharactersOnEvent(characters, theChosens, 3);
                    Console.WriteLine("Ha ocurrido un terremoto en la zona 3");

                    ApplyDamageForAll(theChosens, 4);

                    foreach (Personaje personaje in theChosens)
                    {
                        if (personaje.vida <= 0)
                            Console.WriteLine($"{personaje.nombre} no ha aguantado el terremoto");
                        else
                            Console.WriteLine($"{personaje.nombre} ha caído en el terremoto, pero vuelve con {personaje.vida}");
                    }
                }
                break;

            case 5:
                {
                    PutCharactersOnEvent(characters, theChosens, 3);
                    Console.WriteLine($"{theChosens[0].nombre} ha decidido curarse, y ha invitado a {theChosens[1].nombre} y a {theChosens[2].nombre} en la zona 3");

                    ApplyDamageForAll(theChosens, -3); // Curación
                }
                break;

            // Zona 4
            case 6:
                Console.WriteLine("Un pajarito se ha caído en un árbol en la zona 4, pobrecito");
                break;

            case 7:
                Console.WriteLine("No ha pasado nada... qué triste");
                break;

            // Zona final
            case 8:
                {
                    Personaje theChosenOne = GetRandomCharacter(characters);
                    Console.WriteLine($"Un rayo ha caído, haciendo mucho daño a {theChosenOne.nombre}");
                    ApplyDamage(theChosenOne, characters, 10);
                }
                break;

            case 9:
                {
                    Personaje theChosenOne = GetRandomCharacter(characters);
                    Console.WriteLine($"Los dioses han bendecido a {theChosenOne.nombre}, curándole muchísima vida");
                    ApplyDamage(theChosenOne, characters, -10);
                }
                break;
            
            default:
                Console.WriteLine("Una lluvia curadora ha llegado a la zona 1, curando a los supervivientes 2 de vida");
                ApplyDamageForAll(characters, -2);
                break;
        }
    }

    private Personaje GetRandomCharacter(List<Personaje> characters)
    {
        return characters[rng.Next(0, characters.Count)];
    }

    private void PutCharactersOnEvent(List<Personaje> characters, List<Personaje> theChosens, int numberOfCharacters)
    {
        if (characters.Count == 0) return;

        if (numberOfCharacters > characters.Count)
            numberOfCharacters = characters.Count;

        for (int i = 0; i < numberOfCharacters; i++)
        {
            Personaje elegido;
            do
            {
                elegido = characters[rng.Next(0, characters.Count)];
            }
            while (theChosens.Contains(elegido));

            theChosens.Add(elegido);
        }
    }

    private void ApplyDamageForAll(List<Personaje> characters, int damage)
    {
        List<Personaje> muertos = new List<Personaje>();

        foreach (var character in characters)
        {
            character.vida -= damage;

            if (character.vida <= 0)
            {
                Console.WriteLine($"{character.nombre} ha muerto");
                muertos.Add(character);
            }
        }

        foreach (var muerto in muertos)
        {
            characters.Remove(muerto);
        }
    }

    private void ApplyDamage(Personaje charact, List<Personaje> characters, int damage)
    {
        charact.vida -= damage;

        if (charact.vida <= 0)
        {
            Console.WriteLine($"{charact.nombre} ha muerto");
            characters.Remove(charact);
        }
    }
}
namespace AJ_Proyecto1;

public class Combate
{
    
    //Atributos
    private Random rng = new Random();
    
    public void Pelea(List<Personaje> personajes)
    {
        List<Personaje> original = new List<Personaje>(personajes);
        
        foreach (Personaje personaje in personajes)
        {
            Iniciativa(personaje);
            if (personaje.comment || personaje == personajes[0])
            {
                Console.WriteLine(personaje.nombre + " ha sacado: " + personaje.iniciativa + " en iniciativa");
            }
        }

        while (personajes.Count > 1)
        {
            personajes.Sort((a, b) => b.iniciativa.CompareTo(a.iniciativa));

            List<Personaje> muertos = new List<Personaje>();

            for (int i = 0; i < personajes.Count; i++)
            {
                if (personajes[i].vida <= 0)
                    continue;

                if (personajes.Count == 1)
                    break;

                int objetivo;
                do
                {
                    objetivo = rng.Next(0, personajes.Count);
                }
                while (objetivo == i || personajes[objetivo].vida <= 0);
                personajes[objetivo].vecesSeleccionado++;

                if (original[0].comment || personajes[i] == original[0] || personajes[objetivo] == original[0] ||
                    !(original[0].player)) 

                
                {
                    if (personajes[objetivo].chapita > LanzarDado())
                    {
                        Console.WriteLine($"{personajes[i].nombre} N0 ha hecho daño WOMP WOMP.");
                    }
                    else
                    {
                        
                        int daño = ElegirAtaque(personajes[i], original);
                        personajes[objetivo].vida -= daño;
                        Console.WriteLine($"{personajes[i].nombre} hace {daño} de daño a {personajes[objetivo].nombre}");
                        Console.WriteLine($"Vida restante de {personajes[objetivo].nombre}: {personajes[objetivo].vida}");
                    }
                }

                if (personajes[objetivo].vida <= 0)
                    muertos.Add(personajes[objetivo]);
            }

            foreach (var muerto in muertos)
            {
                Console.WriteLine("Han muerto: " + muerto.nombre);
                personajes.Remove(muerto);
            }
        }
        
        Console.WriteLine("Ha ganado: " + personajes[0].nombre + ", que se ha quedado con: " 
                          + personajes[0].vida + " , que lo han seleccionado: " 
                          + personajes[0].vecesSeleccionado);
        Thread.Sleep(3000);
    }

    private void Iniciativa(Personaje p1)
    {
        p1.iniciativa = LanzarDado(p1.destreza);
    }

    private int LanzarDado(int atributo = 10, int tipoDado=20)
    {
        int modificador = (int)Math.Floor((atributo - 10) / 2.0); //Lo que hace (int)Math.Floor() es truncar hacia abajo
        int dado = rng.Next(1,tipoDado+1);
        
        if ((dado + modificador) <= 0)
        {
            //Console.WriteLine($"Dado: {dado}, Modificador: {modificador}");
            return 0;
        }
        else
        {
            //Console.WriteLine($"Dado: {dado}, Modificador: {modificador}");
            return dado + modificador;
        }
    }

    private int ElegirAtaque(Personaje p, List<Personaje> characters)
    {
        if (p.player)
        {
            for (int i = 1; i < p.ataques.Count+1; i++)
            {
                Console.WriteLine("Ataque "+ i +": " + p.ataques[i-1].nombreAtaque);
            }
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > p.ataques.Count)
            {
                Console.WriteLine("Número inválido. Elige un ataque entre 1 y " + p.ataques.Count);
            }

            
            Console.WriteLine($"{p.nombre} ha escogido: " + p.ataques[numero-1].nombreAtaque);
            
            
            return LanzarDado(p.ataques[numero-1].atributo, p.ataques[numero-1].caraDedados);
        }
        else
        {
            int numero = rng.Next(1, p.ataques.Count + 1);
            if (characters[0].comment ||
                !(characters[0].player))
            {
                Console.WriteLine($"{p.nombre} ha escogido: " + p.ataques[numero-1].nombreAtaque);

            }
            return LanzarDado(p.ataques[numero-1].atributo, p.ataques[numero-1].caraDedados);
        }
    }
}
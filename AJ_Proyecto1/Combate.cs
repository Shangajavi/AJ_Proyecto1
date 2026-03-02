namespace AJ_Proyecto1;

public class Combate
{
    
    //Atributos
    public List<Personaje> personasInvolucradas = new List<Personaje>();
    private Random rng = new Random();
    
    public void Pelea(List<Personaje> personajes)
    {

        while(personajes.Count > 1){
            foreach (Personaje personaje in personajes)
            {
                Iniciativa(personaje);
                Console.WriteLine(personaje + " ha sacado: " + personaje.iniciativa);
            }


            personajes.Sort((a, b) => b.iniciativa.CompareTo(a.iniciativa));

            List<int> muertos = new List<int>();

            for (int i = 0; i < personajes.Count; i++)
            {
                int tamano = personajes.Count;
                if (tamano == 1) break;

                int objetivo;
                do
                {
                    objetivo = rng.Next(0, tamano);
                } while (objetivo == i);

                personajes[objetivo].vida -= ElegirAtaque(personajes[i]);

                if (personajes[objetivo].vida <= 0)
                    muertos.Add(objetivo);
            }

            muertos.Sort();
            muertos.Reverse();

            foreach (int muerto in muertos)
            {
                personajes.RemoveAt(muerto);
            }
        }
        
    }

    private void Iniciativa(Personaje p1)
    {
        p1.iniciativa = LanzarDado(p1.destreza);
    }

    private int LanzarDado(int atributo, int tipoDado=20)
    {
        int modificador = (int)Math.Floor((atributo - 10) / 2.0); //Lo que hace (int)Math.Floor() es truncar hacia abajo
        int dado = rng.Next(1,tipoDado+1);

        if ((dado + modificador) <= 0)
        {
            Console.WriteLine($"Dado: {dado}, Modificador: {modificador}");
            return 0;
        }
        else
        {
            Console.WriteLine($"Dado: {dado}, Modificador: {modificador}");
            return dado + modificador;
        }
    }

    private int ElegirAtaque(Personaje p)
    {
        if (p.player)
        {
            for (int i = 1; i < p.ataques.Count+1; i++)
            {
                Console.WriteLine("Ataque "+ i +": " + p.ataques[i-1]);
            }
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > p.ataques.Count)
            {
                Console.WriteLine("Número inválido. Elige un ataque entre 1 y " + p.ataques.Count);
            }

            
            Console.WriteLine("Ha escogido: " + p.ataques[numero-1].nombreAtaque);
            
            return LanzarDado(p.ataques[numero-1].atributo, p.ataques[numero-1].caraDedados);
        }
        else
        {
            int numero = rng.Next(1, p.ataques.Count + 1);
            
            Console.WriteLine("Ha escogido: " + p.ataques[numero-1].nombreAtaque);

            return LanzarDado(p.ataques[numero-1].atributo, p.ataques[numero-1].caraDedados);
        }
    }
}
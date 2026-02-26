namespace AJ_Proyecto1;

public class Combate
{
    
    //Atributos
    public Personaje personaje1;
    public Personaje personaje2;
    private Random rng = new Random();
    
    public void Pelea(Personaje p1, Personaje p2)
    {
        

        Personaje primero;
        Personaje segundo;

        do
        {
            Iniciativa(p1, p2);
            Console.WriteLine($"{p1.nombre} ha sacado {p1.iniciativa}, y {p2.nombre} ha sacado {p2.iniciativa}");
            if (p1.iniciativa > p2.iniciativa)
            {
                primero = p1;
                segundo = p2;
            }
            else
            {
                primero = p2;
                segundo = p1;
            }
            Console.WriteLine($"{primero.nombre} va primero y {segundo.nombre} va segundo");
        } while (p1.iniciativa == p2.iniciativa);

        while (p1.vida >0 && p2.vida >0)
        {

            int ataque1 = ElegirAtaque(primero);
            Console.WriteLine($"{primero.nombre} ha hecho {ataque1}");
            segundo.vida -= ataque1;
            if (segundo.vida <= 0)
            {
                segundo.vida = 0;
                break;
            }
            Console.WriteLine($"{segundo.nombre} tiene {segundo.vida}");
            int ataque2 = ElegirAtaque(segundo);
            Console.WriteLine($"{segundo.nombre} ha hecho {ataque2}");
            primero.vida -= ataque2;
            Console.WriteLine($"{primero.nombre} tiene {primero.vida}");
            Thread.Sleep(3000);
        }


    }

    private void Iniciativa(Personaje p1, Personaje p2)
    {
        p1.iniciativa = LanzarDado(p1.destreza);
        p2.iniciativa = LanzarDado(p2.destreza);
    }

    public int LanzarDado(int atributo, int tipoDado=20)
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

    public int ElegirAtaque(Personaje p)
    {
        if (p.player)
        {
            //Funcion que elige ataque
            return LanzarDado(p.destreza, p.ataque1);
        }
        else
        {
            //Funcion que elige ataque aleatoriamente
            return LanzarDado(p.destreza, p.ataque1);
        }
    }
}
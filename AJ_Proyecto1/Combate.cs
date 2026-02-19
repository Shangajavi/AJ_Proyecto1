namespace AJ_Proyecto1;

public class Combate
{
    
    //Atributos
    public Personaje personaje1;
    public Personaje personaje2;
    private Random rng = new Random();
    

    
    
    public void combate(Personaje p1, Personaje p2)
    {
        

        Personaje primero;
        Personaje segundo;

        do
        {
            Iniciativa(p1, p2);
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
        } while (p1.iniciativa == p2.iniciativa);

        while (p1.vida >=0 || p2.vida >=0)
        {
            
            segundo.vida -= ElegirAtaque(primero);
            primero.vida -= ElegirAtaque(segundo);
            
        }


    }

    private void Iniciativa(Personaje p1, Personaje p2)
    {
        p1.iniciativa = LanzarDado(p1.destreza);
        p2.iniciativa = LanzarDado(p2.destreza);
    }

    public int LanzarDado(int atributo, int tipodado=20)
    {
        int modificador = (int)Math.Floor((atributo - 10) / 2.0); //Lo que hace (int)Math.Floor() es truncar hacia abajo
        int dado = rng.Next(1,tipodado+1);

        return dado + modificador;
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
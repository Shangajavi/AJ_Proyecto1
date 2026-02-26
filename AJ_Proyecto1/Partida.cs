namespace AJ_Proyecto1;

public class Partida
{
    public int num_personajes;
    private int tamano_x;
    private int tamano_y;
    private Random rng = new Random();

    public Partida(int num_personajes)
    {
        this.num_personajes = num_personajes;
        tamano_x = num_personajes * 3;
        tamano_y = num_personajes * 3;
    }
    
}
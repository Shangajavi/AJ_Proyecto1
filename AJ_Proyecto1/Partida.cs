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
        
    }
    
    
}
namespace AJ_Proyecto1;

public class Combate
{
    
    //Atributos
    public Personaje personaje1;
    public Personaje personaje2;
    private Random rng = new Random();
    private Personaje[] iniciativa = [];
    
    
    public void combate(Personaje p1, Personaje p2)
    {
        int dado_1 = LanzarDado(p1.fuerza);



    }

    public int LanzarDado(int atributo)
    {
        int modificador = (int)Math.Floor((atributo - 10) / 2.0); //Lo que hace (int)Math.Floor() es truncar hacia abajo
        int dado = rng.Next(1,21);

        return dado + modificador;
    }
}
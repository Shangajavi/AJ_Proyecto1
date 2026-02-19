namespace AJ_Proyecto1;

public class Combate
{
    
    //Atributos
    public Personaje personaje1;
    public Personaje personaje2;
    private Random rng = new Random();
    private List<int> iniciativa = new List<int>();

    
    
    public void combate(Personaje p1, Personaje p2)
    {
        int dado_1 = LanzarDado(p1.destreza);
        int dado_2 = LanzarDado(p2.destreza);
        
        iniciativa.Add(dado_1);
        iniciativa.Add(dado_2);
        iniciativa.Sort(); // Pilla las dos iniciativas y ve cual es mayor
        
        


    }

    public int LanzarDado(int atributo)
    {
        int modificador = (int)Math.Floor((atributo - 10) / 2.0); //Lo que hace (int)Math.Floor() es truncar hacia abajo
        int dado = rng.Next(1,21);

        return dado + modificador;
    }
}
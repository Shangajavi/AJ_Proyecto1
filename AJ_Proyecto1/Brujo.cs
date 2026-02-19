namespace AJ_Proyecto1;

public class Brujo : Personaje
{
    public string ataque2;
    public string ataque3;

    public Brujo(string nombre, bool player = false) : base(nombre,player)
    {
        this.nombre = nombre;
        this.destreza = 13;
        this.fuerza = 8;
        this.constitucion = 14;
        this.inteligencia = 15;
        this.sabiduria = 12;
        this.carisma = 10;
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);
        this.player = player;
    }
}
namespace AJ_Proyecto1;

public class Picaro : Personaje
{
    public int ataqueFurtvio = 6;
    public int armaArrojadiza = 4;

    public Picaro(string nombre, string ataque2, string ataque3, bool player = false)
        : base(nombre, player)
    {
        this.nombre = nombre;
        this.destreza = 15;
        this.fuerza = 8;
        this.constitucion = 14;
        this.inteligencia = 10;
        this.sabiduria = 13;
        this.carisma = 12;
        
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);
        
        this.player = player;
    }
}
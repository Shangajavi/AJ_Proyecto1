namespace AJ_Proyecto1;

public class Brujo : Personaje
{
    public string ataque2;
    public string ataque3;

    public Brujo(string nombre,int destreza = 13, int fuerza = 8, int constitucion = 14, int inteligencia = 10, int sabiduria = 12, int carisma = 15, int vida = 8) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        this.nombre = nombre;
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);
    }
}
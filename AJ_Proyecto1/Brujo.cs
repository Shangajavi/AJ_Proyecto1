namespace AJ_Proyecto1;

public class Brujo : Personaje
{
    public int eldritchBlast = 10;   //En teoría le sumas el nivel de carísma que tengas.
    public int witchBolt = 12;

    public Brujo(string nombre,int destreza = 13, int fuerza = 8, int constitucion = 14, int inteligencia = 10, int sabiduria = 12,
        int carisma = 15) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        this.nombre = nombre;
    }
}
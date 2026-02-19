namespace AJ_Proyecto1;

public class Druida : Personaje
{
    public int thornWhip = 6;
    public int produceFlame = 8;

    public Druida(string nombre,int destreza = 13, int fuerza = 10, int constitucion = 14, int inteligencia = 12, int sabiduria = 15,
        int carisma = 8) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        this.nombre = nombre;
    }
}
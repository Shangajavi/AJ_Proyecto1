namespace AJ_Proyecto1;

public class Picaro : Personaje
{
    public int atataqueFurtivo = 6;
    public int armaArrojadiza = 4;

    public Picaro(string nombre,int destreza = 15, int fuerza = 8, int constitucion = 14, int inteligencia = 10, int sabiduria = 13,
        int carisma = 12) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        this.nombre = nombre;
    }
}
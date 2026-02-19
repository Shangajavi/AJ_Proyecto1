namespace AJ_Proyecto1;

public class Barbaro : Personaje
{
    public int ataqueConFuerza = 12;
    public int bofetonHistorico = 10;
    public int furia;

    public Barbaro(string nombre,int destreza = 14, int fuerza = 14, int constitucion = 14, int inteligencia = 10, int sabiduria = 12,
        int carisma = 8) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        this.nombre = nombre;
    }






}
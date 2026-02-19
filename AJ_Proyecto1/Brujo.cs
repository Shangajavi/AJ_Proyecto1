namespace AJ_Proyecto1;

public class Brujo : Personaje
{
    public string ataque2;
    public string ataque3;

    public Brujo(string nombre,int destreza, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma,
        string ataque2, string ataque3) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        destreza = 13;
        fuerza = 8;
        constitucion = 14;
        inteligencia = 10;
        sabiduria = 12;
        carisma = 15;
        this.ataque2 = ataque2;
        this.ataque3 = ataque3;
    }
}
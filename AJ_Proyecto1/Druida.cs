namespace AJ_Proyecto1;

public class Druida : Personaje
{
    public string ataque2;
    public string ataque3;

    public Druida(string nombre,int destreza, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma,
        string ataque2, string ataque3) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        destreza = 13;
        fuerza = 10;
        constitucion = 14;
        inteligencia = 12;
        sabiduria = 15;
        carisma = 8;
        this.ataque2 = ataque2;
        this.ataque3 = ataque3;
    }
}
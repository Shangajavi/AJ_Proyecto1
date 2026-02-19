namespace AJ_Proyecto1;

public class Picaro : Personaje
{
    public string ataque2;
    public string ataque3;

    public Picaro(string nombre,int destreza, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma,
        string ataque2, string ataque3) : base(nombre)
    {
        destreza = 15;
        fuerza = 8;
        constitucion = 14;
        inteligencia = 10;
        sabiduria = 13;
        carisma = 12;
        this.ataque2 = ataque2;
        this.ataque3 = ataque3;
    }
}
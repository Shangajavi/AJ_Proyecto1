namespace AJ_Proyecto1;

public class Picaro : Personaje
{
    public string ataque1;
    public string ataque2;

    public Picaro(string nombre,int destreza, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma,
        string ataque1, string ataque2) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        this.ataque1 = ataque1;
        this.ataque2 = ataque2;
    }
}
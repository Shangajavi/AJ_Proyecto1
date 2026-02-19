namespace AJ_Proyecto1;

public class Mago : Personaje //Estoy probando con la primera clase, que he llamado el mago...
{
    // En teoría un mago tiene un total de 6 hechizos de nivel un, pero para esta prueba solo le voy a dar 2
    public string hechizo2;
    public string hechizo3;
    
    //No estoy seguro si esto es correcto pero considero que esto está ma o menos bien...
    public Mago(string nombre,int destreza, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma,
        string hechizo2, string hechizo3) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        destreza = 13;
        fuerza = 8;
        constitucion = 14;
        inteligencia = 15;
        sabiduria = 12;
        carisma = 10;
        this.hechizo2 = hechizo2;
        this.hechizo3 = hechizo3;
    }


}
namespace AJ_Proyecto1;

public class Mago : Personaje //Estoy probando con la primera clase, que he llamado el mago...
{
    // En teoría un mago tiene un total de 6 hechizos de nivel un, pero para esta prueba solo le voy a dar 2
    public string hechizo1;
    public string hechizo2;
    
    //No estoy seguro si esto es correcto pero considero que esto está ma o menos bien...
    public Mago(string nombre,int destreza, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma,
        string hechizo1, string hechizo2) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        this.hechizo1 = hechizo1;
        this.hechizo2 = hechizo2;
    }


}
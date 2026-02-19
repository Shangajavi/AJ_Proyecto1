namespace AJ_Proyecto1;

public class Mago : Personaje //Estoy probando con la primera clase, que he llamado el mago...
{
    // En teoría un mago tiene un total de 6 hechizos de nivel un, pero para esta prueba solo le voy a dar 2
    public int fireBolt = 12;
    public int rayOfFrost = 8;
    
    //No estoy seguro si esto es correcto, pero considero que esto está ma o menos bien...
    public Mago(string nombre,int destreza = 13, int fuerza = 8, int constitucion = 14, int inteligencia = 15, int sabiduria = 12,
        int carisma = 10) : base(nombre,destreza,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
        this.nombre = nombre;
    }


}
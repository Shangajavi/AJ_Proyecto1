namespace AJ_Proyecto1;

public class Personaje  //Aquí introduzco los atributos básicos de cada personaje. >:D
{
    public string nombre;   //Por si quieres introducir un nombre
    
    // Estás ya son las stats
    public int fuerza;
    public int constitucion;
    public int inteligencia;
    public int sabiduria;
    public int carisma;

    public Personaje(string nombre, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma)
    {
        this.nombre = nombre;
        this.fuerza = fuerza;
        this.constitucion = constitucion;
        this.inteligencia = inteligencia;
        this.sabiduria = sabiduria;
        this.carisma = carisma;
    }
}


public class Mago : Personaje //Estoy probando con la primera clase, que he llamado el mago...
{
    // En teoría un mago tiene un total de 6 hechizos de nivel un, pero para esta prueba solo le voy a dar 2
    public string hechizo1;
    public string hechizo2;
    
    //No estoy seguro si esto es correcto pero considero que esto está ma o menos bien...
    public Mago(string nombre, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma,
        string hechizo1, string hechizo2) : base(nombre,fuerza,constitucion, inteligencia, sabiduria, carisma)
    {
      this.hechizo1 = hechizo1;
      this.hechizo2 = hechizo2;
    }


}

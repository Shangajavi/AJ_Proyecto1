namespace AJ_Proyecto1;

public class Personaje  //Aquí introduzco los atributos básicos de cada personaje. >:D
{
    public string nombre;   //Por si quieres introducir un nombre
    
    // Estás ya son las stats
    public int destreza;
    public int fuerza;
    public int constitucion;
    public int inteligencia;
    public int sabiduria;
    public int carisma;

    public Personaje(string nombre,int destreza, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma)
    {
        this.nombre = nombre;
        this.destreza = destreza;
        this.fuerza = fuerza;
        this.constitucion = constitucion;
        this.inteligencia = inteligencia;
        this.sabiduria = sabiduria;
        this.carisma = carisma;
    }
}

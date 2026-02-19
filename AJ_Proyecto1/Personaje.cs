namespace AJ_Proyecto1;

public class Personaje  //Aquí introduzco los atributos básicos de cada personaje. >:D
{
    public string nombre;   //Por si quieres introducir un nombre
    
    // Estás ya son las stats
    public int destreza;    //Picaro
    public int fuerza;  //Barbaro
    public int constitucion;    //Nadie
    public int inteligencia;    //Mago
    public int sabiduria;   //Druida
    public int carisma; //Brujo
    public int ataque1 = 4;
    public int vida;
    public int iniciativa;
    public bool player;

    public Personaje(string nombre,int destreza, int fuerza, int constitucion, int inteligencia, int sabiduria, int carisma, bool player=false)
    {
        this.nombre = nombre;
        this.fuerza = fuerza;
        this.constitucion = constitucion;
        this.inteligencia = inteligencia;
        this.sabiduria = sabiduria;
        this.carisma = carisma;
        this.player = player;
    }
}

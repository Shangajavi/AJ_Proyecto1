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
    public int vida = 8;
    public int chapita = 10;
    public int iniciativa;
    public bool player;
    public bool comment;
    public int maxPosicion;
    private bool isSomeoneHere;
    private Random rndPosition = new  Random();
    public List<Ataque> ataques = new List<Ataque>();
    public int vecesSeleccionado=0;


    public Personaje(string nombre, bool player = false, bool comment = false)
    {
        
        this.nombre = nombre; 
        this.player = player;
        this.comment = comment;
        
        int x = Posicion();
        int y = Posicion();

    }

    public int Posicion()
    {
        
        int position = rndPosition.Next(1,1 + maxPosicion); 
        return position;
    }
}

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
    public int vida = 8;
    public int iniciativa;
    public bool player;
    public int maxPosicion;
    private bool isSomeoneHere;
    
    public List<Ataque> ataques;


    public Personaje(string nombre, bool player = false)
    {
        
        this.nombre = nombre;
        this.player = player;
        int x = 0;
        int y = 0;
        //Posicion de x e y para ver donde está cada uno de ellos.
        //Con esto sacas una posicion random de x y de Y.
        PosicionX(x);
        PosicionY(y);
    }

    public int PosicionX(int posicionX)
    {
        int Xposition = 0;
        Random rndX = new Random();
        
        Xposition = rndX.Next(1,1 + maxPosicion); 
        
        return Xposition;
    }
    public int PosicionY(int posicionY)
    {
        int Yposition = 0;
        Random rndY = new Random();
        
        Yposition = rndY.Next(1,1 + maxPosicion); 
        
        return Yposition;
    }
    
}

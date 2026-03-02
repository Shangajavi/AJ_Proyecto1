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
    public int maxPosicionX;
    public int maxPosicionY;
    private bool isSomeoneHere;
    List<Ataque> ataques;


    public Personaje(string nombre, bool player = false)
    {
        
        this.nombre = nombre;
        this.player = player;
        //Posicion de x e y para ver donde está cada uno de ellos.
        this.maxPosicionX = maxPosicionX;
        this.maxPosicionY = maxPosicionY;
        //Con esto sacas una posicion random de x y de Y.
        Random rndX = new Random();
        
        int posicionX = rndX.Next(1,1 + maxPosicionX);
        int posicionY = rndX.Next(1,1 + maxPosicionY);
        
    }



    
    


}

namespace AJ_Proyecto1;

public class Brujo : Personaje
{

    public Ataque eldritchBlast;
    public Ataque witchBolt;
    public Ataque bastonazo;
    public Ataque brazosdeHadar;

    public Brujo(string nombre, bool player = false) : base(nombre,player)
    {
        this.nombre = nombre;
        this.destreza = 13;
        this.fuerza = 8;
        this.constitucion = 14;
        this.inteligencia = 15;
        this.sabiduria = 12;
        this.carisma = 10;
        
        this.eldritchBlast = new Ataque("Eldritch Blast",12,carisma);
        this.witchBolt = new Ataque("Witch Bolt",8,carisma);
        this.bastonazo = new Ataque("Bastonazo",6,carisma);
        this.brazosdeHadar = new Ataque("Brazos de Hadar",10,carisma);
        
        List<Ataque> ataques = new List<Ataque>{eldritchBlast,witchBolt,bastonazo,brazosdeHadar};
        
        
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);
        this.player = player;
    }
}
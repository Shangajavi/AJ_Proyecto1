namespace AJ_Proyecto1;

public class Barbaro : Personaje
{
    public Ataque ataqueConFuerza;
    public Ataque bofeton;
    public Ataque furia;
    public Ataque lanzarLanza;
    

    public Barbaro(string nombre, bool player = false, bool comment = false) : base(nombre,player,comment)
    {
        this.nombre = nombre;

        // Atributos base del Bárbaro
        this.destreza = 14;
        this.fuerza = 14;
        this.constitucion = 14;
        this.inteligencia = 10;
        this.sabiduria = 12;
        this.carisma = 8;
        
        this.ataqueConFuerza = new Ataque("Ataque Con Fuerza",12,fuerza);
        this.bofeton = new Ataque("Bofeton",8,fuerza);
        this.furia = new Ataque("Furia",6,fuerza);
        this.lanzarLanza = new Ataque("Lanzar Lanza",6,fuerza);
        
        ataques.Add(ataqueConFuerza);
        ataques.Add(bofeton);
        ataques.Add(furia);
        ataques.Add(lanzarLanza);
        
        
        
        // Ajuste de vida según Constitución
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);
        this.chapita += (int)Math.Floor((destreza - 10) / 2.0);
        this.player = player;
        this.comment = comment;
    }






}
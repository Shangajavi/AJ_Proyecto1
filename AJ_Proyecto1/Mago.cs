namespace AJ_Proyecto1;

public class Mago : Personaje //Estoy probando con la primera clase, que he llamado el mago...
{
    // En teoría un mago tiene un total de 6 hechizos de nivel un, pero para esta prueba solo le voy a dar 2
    public Ataque FireBall;
    public Ataque Rayo;
    public Ataque Bastonazo;
    public Ataque ArmaduraDeMago;

    
    //No estoy seguro si esto es correcto, pero considero que esto está ma o menos bien...
    public Mago(string nombre, bool player = false, bool comment = false) : base(nombre,player,comment)
    {
        this.nombre = nombre;

        // Atributos base del Mago
        this.destreza = 13;
        this.fuerza = 8;
        this.constitucion = 14;
        this.inteligencia = 15;
        this.sabiduria = 12;
        this.carisma = 10;
        
        
        this.FireBall = new Ataque("Fire Ball",8,inteligencia);
        this.Rayo = new Ataque("Rayo",12,inteligencia);
        this.Bastonazo = new Ataque("Bastonazo",6,fuerza);
        this.ArmaduraDeMago = new Ataque("Armadura De Mago",6,constitucion);
        
        ataques.Add(FireBall);
        ataques.Add(Rayo);
        ataques.Add(Bastonazo);
        ataques.Add(ArmaduraDeMago);
        
        
        
        
        
        // Ajuste de vida según Constitución
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);

        this.player = player;
        this.comment = comment;
    }


}
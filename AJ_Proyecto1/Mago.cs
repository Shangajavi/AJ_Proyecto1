namespace AJ_Proyecto1;

public class Mago : Personaje //Estoy probando con la primera clase, que he llamado el mago...
{
    // En teoría un mago tiene un total de 6 hechizos de nivel un, pero para esta prueba solo le voy a dar 2
    public int fireBall = 8;
    public int rayo = 12;
    
    //No estoy seguro si esto es correcto pero considero que esto está ma o menos bien...
    public Mago(string nombre, bool player = false) 
        : base(nombre, player)
    {
        this.nombre = nombre;

        // Atributos base del Mago
        this.destreza = 13;
        this.fuerza = 8;
        this.constitucion = 14;
        this.inteligencia = 15;
        this.sabiduria = 12;
        this.carisma = 10;

        // Ajuste de vida según Constitución
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);

        this.player = player;
    }


}
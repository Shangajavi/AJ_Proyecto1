namespace AJ_Proyecto1;

public class Barbaro : Personaje
{
    public int ataqueConFuerza = 12;
    public int bofeton = 10;

    public Barbaro(string nombre, bool player = false)
        : base(nombre, player)
    {
        this.nombre = nombre;

        // Atributos base del Bárbaro
        this.destreza = 14;
        this.fuerza = 14;
        this.constitucion = 14;
        this.inteligencia = 10;
        this.sabiduria = 12;
        this.carisma = 8;

        // Ajuste de vida según Constitución
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);

        this.player = player;
    }






}
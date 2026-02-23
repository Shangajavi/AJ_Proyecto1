namespace AJ_Proyecto1;

public class Druida : Personaje
{
    public string ataque2;
    public string ataque3;

    public Druida(string nombre, bool player = false)
        : base(nombre, player)
    {
        this.nombre = nombre;
        this.destreza = 13;
        this.fuerza = 10;
        this.constitucion = 14;
        this.inteligencia = 12;
        this.sabiduria = 15;
        this.carisma = 8;

        // Ajuste de vida según Constitución
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);

        this.player = player;
    }
}
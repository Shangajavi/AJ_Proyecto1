namespace AJ_Proyecto1;

public class Picaro : Personaje
{
    public Ataque ataqueFurtivo;
    public Ataque armaArrojadiza;
    public Ataque cortes;
    public Ataque accionesAstutas;

    public Picaro(string nombre, string ataque2, string ataque3, bool player = false)
        : base(nombre, player)
    {
        this.nombre = nombre;
        this.destreza = 15;
        this.fuerza = 8;
        this.constitucion = 14;
        this.inteligencia = 10;
        this.sabiduria = 13;
        this.carisma = 12;
        
        this.ataqueFurtivo = new Ataque("Ataque Furtivo",6,destreza);
        this.armaArrojadiza = new Ataque("Arma Arrojadiza",4,destreza);
        this.cortes = new Ataque("Cortes",8,destreza);
        this.accionesAstutas = new Ataque("Acciones Astutas",6,destreza);//aumenta CA
        
        ataques.Add(ataqueFurtivo);
        ataques.Add(armaArrojadiza);
        ataques.Add(cortes);
        ataques.Add(accionesAstutas);
        
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);
        
        this.player = player;
    }
}
namespace AJ_Proyecto1;

public class Druida : Personaje
{
  
    public Ataque thornWhip;
    public Ataque produceFlame;
    public Ataque oso;
    public Ataque zancadaProdigiosa;

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

        this.thornWhip = new Ataque("Thorn Whip",10,sabiduria);
        this.produceFlame = new Ataque("Produce Flame",6,sabiduria);
        this.oso = new Ataque("Oso",8,sabiduria);
        this.zancadaProdigiosa = new Ataque("Zancada Prodigiosa",6,sabiduria);//aumenta CA
        
        List<Ataque> ataques = new List<Ataque>{thornWhip,produceFlame,oso,zancadaProdigiosa};
        
        
        // Ajuste de vida según Constitución
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);

        this.player = player;
    }
}
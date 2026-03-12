namespace AJ_Proyecto1;

public class Druida : Personaje
{
  
    public Ataque thornWhip;
    public Ataque produceFlame;
    public Ataque oso;
    public Ataque patadaProdigiosa;

    public Druida(string nombre, bool player = false, bool comment = false) : base(nombre,player,comment)
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
        this.patadaProdigiosa = new Ataque("Zancada Prodigiosa",8,fuerza);
        
        ataques.Add(thornWhip);
        ataques.Add(produceFlame);
        ataques.Add(oso);
        ataques.Add(patadaProdigiosa);
        
        // Ajuste de vida según Constitución
        this.vida += (int)Math.Floor((constitucion - 10) / 2.0);
        this.chapita += (int)Math.Floor(((destreza - 10) / 2.0)-2);
        this.player = player;
        this.comment = comment;
    }
}
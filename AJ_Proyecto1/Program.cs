namespace AJ_Proyecto1;


class Program
{
    static void Main(string[] args)
    {

        /*Mago BrujoTest = new Mago("Enrique");
        Brujo BrujoTest2 = new Brujo("Miguel");

        Combate pelea = new Combate();
        
        pelea.Pelea(BrujoTest2,BrujoTest);
        // La vida va medio rara y los ataques solo dan 0*/

        
        int numeropersonajes = int.Parse(Console.ReadLine());
        
        Partida partida = new Partida(numeropersonajes);
        Mapa mapa = new Mapa(partida.num_personajes, partida.num_personajes);
        
        mapa.CrearMapa();
        
    }
}
namespace AJ_Proyecto1;


class Program
{
    static void Main(string[] args)
    {

        Mago BrujoTest = new Mago("Enrique");
        Brujo BrujoTest2 = new Brujo("Miguel");
        Brujo BrujoTest3 = new Brujo("Alejandro", true);
        Brujo BrujoTest4 = new Brujo("Amargao Javi");
        Brujo BrujoTest5 = new Brujo("Mateo");

        List<Personaje> personajes = new List<Personaje>();
        personajes.Add(BrujoTest);
        personajes.Add(BrujoTest2);
        personajes.Add(BrujoTest3);
        personajes.Add(BrujoTest4);
        personajes.Add(BrujoTest5);
        
        Combate pelea = new Combate();
        
        pelea.Pelea(personajes);

        
        /*int numeropersonajes = int.Parse(Console.ReadLine());
        
        Partida partida = new Partida(numeropersonajes);
        Mapa mapa = new Mapa(partida.num_personajes, partida.num_personajes);
        
        mapa.CrearMapa();*/
        
        
        
    }
}
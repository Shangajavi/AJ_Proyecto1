namespace AJ_Proyecto1;


class Program
{
    static void Main(string[] args)
    {
        Mago MagoTest = new Mago("Jorge",1,1,2,3,4,5, 
            "Bolas de Fuego","Bolas Negras");
        Console.WriteLine("I cast: ");
        Console.WriteLine(MagoTest.hechizo2);

        Brujo BrujoTest = new Brujo("Enrique");
        Brujo BrujoTest2 = new Brujo("Miguel");

        Combate pelea = new Combate();
        
        pelea.combate(BrujoTest2,BrujoTest);
        // La vida va medio rara y los ataques solo dan 0
    }
}
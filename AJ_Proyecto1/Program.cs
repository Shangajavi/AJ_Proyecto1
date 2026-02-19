namespace AJ_Proyecto1;


class Program
{
    static void Main(string[] args)
    {
        Mago MagoTest = new Mago("Jorge",1,2,3,4,5,"Bolas de Fuego","Bolas Negras");
        Console.WriteLine("I cast: ");
        Console.WriteLine(MagoTest.hechizo2);
    }
}
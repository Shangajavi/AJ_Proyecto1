namespace AJ_Proyecto1;

public class Mapa
{
    public int tamano_x;
    public int tamano_y;
    private int[,] mapa;

    public Mapa(int tamano_x, int tamano_y)
    {
        this.tamano_x = tamano_x;
        this.tamano_y = tamano_y;

        mapa = new int[tamano_x, tamano_y];
    }

    public void CrearMapa()
    {
        for (int y = 0; y < tamano_y; y++)
        {
            for (int x = 0; x < tamano_x; x++)
            {
                Console.Write(mapa[y, x] == 1 ? "P" : " - ");
            }
            Console.WriteLine();
        }
    }
}
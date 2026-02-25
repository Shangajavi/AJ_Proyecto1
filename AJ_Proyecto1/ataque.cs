namespace AJ_Proyecto1;

public class ataque
{
    public int dado;
    private int valor;
    public int lanzarDados(int dado, int valor)
    {
        this.dado = dado;
        this.valor = valor;
    public enum DadoOpcion
        {
            D1 = 1,
            D2 = 2,
            D3 = 3,
            D4 = 4,
            D5 = 5
        }

    }
    
    
    
    
    
    
    
    
    


    //Estos son los distintos dados y voy a poner que en cada uno de ellos de un numero al azar
    public int dado4()
    {
       Random rnd = new Random();
       var r =  rnd.Next(1, 5);
       return r;
    }
    public int dado6()
    {
        Random rnd = new Random();
        var r =  rnd.Next(1, 7); 
        return r;
    }
    public int dado8()
    {
        Random rnd = new Random();
        var r =  rnd.Next(1, 9); 
        return r;
    }
    public int dado10()
    {
        Random rnd = new Random();
        var r =  rnd.Next(1, 11);
        return r;
    }
    public int dado12()
    {
        Random rnd = new Random();
        var r =  rnd.Next(1, 13);
        return r;
    }
    
    
    
    
}
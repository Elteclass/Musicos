//clase Musico
abstract class Musico
{
    //Atributos
    public string Nombre {get; set;}
    
    //Constructor
    public Musico (string n)
    {
        Nombre = n;
    }

    //Método
    public void Saludar()
    {
        Console.WriteLine("Hola soy {0}", Nombre);
    }
    public abstract void Toca();//Los metodos abstractos se delegan de manera obligatoria
    /*{
        Console.WriteLine($"{Nombre}, esta tocando su instrumento");
    }*/

}

//clase bajista
class Bajista:Musico
{
    public string Bajo {get; set;}

    //Constructor
    public Bajista(string n, string bajo):base(n)
    {
        Bajo = bajo;
    }

    //Métodos
    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su {Bajo}");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        //Lista
        List<Musico> grupo = new List<Musico>();
        grupo.Add(new Bajista("Maria", "Fluta"));
        //grupo.Add(new Musico ("Pancho"));

        Console.WriteLine("Los integrantes del grupo son los siguientes:");

        foreach ( var m in grupo )
        {
            m.Saludar();
            m.Toca();
        }

        Console.WriteLine("Los Musicos son:");

        /*Musico y = new Musico("Pancho");
        y.Saludar();
        y.Toca();*/
        Bajista x = new Bajista("Maria", "Flauta");
        x.Toca();
    }
}

// Poner baterista y guitarrista
//Las clases abstractas solo pueden crear referencias y no objetos
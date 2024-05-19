namespace HotdogShop;

public class Venda
{
    // Atributos
    private Cliente cliente;
    private float preçoSemDesconto;
    private float preçoComDesconto;
    private int quantidadeSalcicha;
    private int quantidadeLinguiça;
    private int quantidadeFrango;
    private int quantidadeBacon;

    // Prop
    public Cliente Cliente { get { return cliente; } }
    public float PreçoSemDesconto { get { return preçoSemDesconto; }set { preçoSemDesconto = value; } }
    public float PreçoComDesconto { get { return preçoComDesconto; } set { preçoComDesconto = value; } }
    public int QuantidadeSalcicha { get { return quantidadeSalcicha; } set { quantidadeSalcicha = value; } }
    public int QuantidadeLinguiça { get { return quantidadeLinguiça; } set { quantidadeLinguiça = value; } }
    public int QuantidadeFrango { get { return quantidadeFrango; } set { quantidadeFrango = value; } }
    public int QuantidadeBacon { get { return quantidadeBacon; } set { quantidadeBacon = value; } }    

    // Ctor
    public Venda(Cliente cliente)
    {
        this.cliente = cliente;

        foreach (var c in cliente.Hotdogs)
        {
            preçoSemDesconto += c.Preço;
            if(c is Salcicha)
                quantidadeSalcicha++;
            else if(c is Linguiça)
                quantidadeLinguiça++;
            else if(c is Frango)
                quantidadeFrango++;
            else
                quantidadeBacon++;
        }
        Console.WriteLine($"{preçoComDesconto} - {preçoSemDesconto}");
        if(quantidadeSalcicha >= 2)
            preçoComDesconto = 0.9f*preçoSemDesconto;

        if(quantidadeLinguiça >= 2)
            preçoComDesconto = 0.88f*preçoSemDesconto;
        
        if(quantidadeFrango >= 3)
            preçoComDesconto = 0.87f*preçoSemDesconto;

        if(quantidadeBacon >= 4)
            preçoComDesconto = 0.86f*preçoSemDesconto;
        
        Console.WriteLine($"{preçoComDesconto} - {preçoSemDesconto}");
    }
    public override string ToString()
    {   
        string resp = $"{Cliente}";
        for (int i = 0; i < Cliente.Hotdogs.Count; i++)
        {
            resp += $"\n{Cliente.Hotdogs[i]}";
        }

        return resp;
    }

}
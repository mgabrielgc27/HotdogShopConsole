namespace HotdogShop;

public class Cliente
{
    // Atributos
    private int identificador;
    private string ? name;
    private ECliente tipo;
    private List<Hotdog> hotdogs;

    // Propriedades
    public int Identificador { get { return identificador; } }
    public string ? Name { get { return name; } }
    public ECliente Tipo { get { return tipo; } }

    public List<Hotdog> Hotdogs
    { 
        get { return hotdogs; }

        set
        {
            if (value != null)
            {
                hotdogs = value;
            }
        } 
    }

    // Construtor
    public Cliente(int identificador, string ? name, ECliente tipo){
        this.identificador = identificador;
        this.tipo = tipo;
        this.name = name;
        hotdogs = [];
    }

}
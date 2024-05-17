namespace HotdogShop;

public class Cliente
{
    // Atributos
    private int identificador;
    private string ? name;
    private ECliente tipo;
    private List<Hotdog> hotdogs;

    // Propriedades
    public int Identificador { get { return identificador; } set { identificador = value; } }
    public string ? Name { get { return name; } set { name = value; } }
    public ECliente Tipo { get { return tipo; } set { tipo = value; } }

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

    public Cliente(){
        hotdogs = new List<Hotdog>();
    }

}
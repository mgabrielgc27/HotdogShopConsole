namespace HotdogShop;

public class Hotdog
{
    public float preço;
    private EQueijo queijo;
    private List<EAdicionais> ? adicionais;
    private EBebida bebida;

    public float Preço { get { return preço; } set{ preço = value; } }
    public EQueijo Queijo { get { return queijo; } set{ queijo = value; } }
    public List<EAdicionais>? Adicionais { get { return adicionais; } set{ adicionais = value; } }
    public EBebida Bebida { get { return bebida; } set{ bebida = value; } }

    public Hotdog(EQueijo queijo, List<EAdicionais> ? adicionais, EBebida bebidas)
    {
        this.queijo = queijo;
        this.adicionais = adicionais;
        this.bebida = bebidas;
    }

    public Hotdog()
    {
        adicionais = new List<EAdicionais>();
    }
}
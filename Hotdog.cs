namespace HotdogShop;

public class Hotdog(EProteina proteina, EQueijo queijo, List<EAdicionais> adicionais, EBebida bebidas)
{
    // private EProteina proteina = proteina;
    // private EQueijo queijo = queijo;
    // private List<EAdicionais> ? adicionais = adicionais;
    // private EBebida bebidas = bebidas;

    public EProteina Proteina { get; } = proteina;
    public EQueijo Queijo { get; } = queijo;
    public List<EAdicionais> Adicionais { get; } = adicionais;
    public EBebida Bebidas { get; } = bebidas;

    public override string ToString()
    {
        return $"Cachorro-quente com {Proteina}, queijo {Queijo}, {Adicionais} e {Bebidas}";
    }
}
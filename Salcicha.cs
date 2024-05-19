namespace HotdogShop;

public class Salcicha : Hotdog
{
    
    public Salcicha(EQueijo queijo, List<EAdicionais>? adicionais, EBebida bebidas) : base(queijo, adicionais, bebidas)
    {
        Preço = 2f;
    }

    public Salcicha()
    {
        Preço = 2f;
    }

    public override string ToString()
    {
        return "Salcicha";
    }
}
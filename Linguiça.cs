namespace HotdogShop;

public class Linguiça : Hotdog
{
    
    public Linguiça(EQueijo queijo, List<EAdicionais>? adicionais, EBebida bebidas) : base(queijo, adicionais, bebidas)
    {
        Preço = 3;
    }

    public Linguiça()
    {
        Preço = 3;
    }

    public override string ToString()
    {
        return "Linguiça";
    }
}
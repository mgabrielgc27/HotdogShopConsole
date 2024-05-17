namespace HotdogShop;

public class Bacon : Hotdog
{
    
    public Bacon(EQueijo queijo, List<EAdicionais>? adicionais, EBebida bebidas) : base(queijo, adicionais, bebidas)
    {
        Preço = 3.5f;
    }

    public Bacon()
    {
        
    }

    public override string ToString()
    {
        return "Bacon";
    }
}
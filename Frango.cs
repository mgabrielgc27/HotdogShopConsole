namespace HotdogShop;

public class Frango : Hotdog
{
    
    public Frango(EQueijo queijo, List<EAdicionais>? adicionais, EBebida bebidas) : base(queijo, adicionais, bebidas)
    {
        Preço = 2.5f;
    }

    public Frango()
    {
        
    }

    public override string ToString()
    {
        return "Frango";
    }
}
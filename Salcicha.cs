namespace HotdogShop;

public class Salcicha : Hotdog
{
    
    public Salcicha(EQueijo queijo, List<EAdicionais>? adicionais, EBebida bebidas) : base(queijo, adicionais, bebidas)
    {
        Preço = 2;
    }

    public Salcicha()
    {
        
    }

    public override string ToString()
    {
        return "Salcinha";
    }
}
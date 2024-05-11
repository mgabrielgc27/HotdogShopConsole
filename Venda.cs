namespace HotdogShop;

public class Venda
{
    // Atributos
    private Cliente cliente;

    // Prop
    public Cliente Cliente { get { return cliente; } }

    // Ctor
    public Venda(Cliente cliente)
    {
        this.cliente = cliente;
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
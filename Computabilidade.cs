
namespace HotdogShop;

public class Computabilidade
{
    internal static string BedidaMaisVendida(List<Venda> vendas)
    {
        string bebida = "";

        int quantCocaCola = 0;
        int quantDelRio = 0;
        int quantSucodoChaves = 0;

        foreach (var v in vendas)
        {
            foreach (var b in v.Cliente.Hotdogs)
            {
                if(b.Bebida == EBebida.COCA_COLA)
                    quantCocaCola++;
                else if(b.Bebida == EBebida.DEL_RIO)
                    quantDelRio++;
                else if(b.Bebida == EBebida.SUCO_DO_CHAVES)
                    quantSucodoChaves++;
            }
        }

        if(quantCocaCola >= quantDelRio && quantCocaCola >= quantSucodoChaves)
            bebida += "Coca-cola";
        else if(quantDelRio >= quantCocaCola && quantDelRio >= quantSucodoChaves)
            bebida += "DelRio";
        else if(quantSucodoChaves >= quantCocaCola && quantSucodoChaves >= quantDelRio)
            bebida += "Suco do Chaves";
            
        return bebida;
    }

    internal static string CachorroQuenteMaisVendido(List<Venda> vendas)
    {
        string hotdog = "";

        int quantSalcicha = 0;
        int quantLinguiça = 0;
        int quantFrango = 0;
        int quantBacon = 0;

        foreach (var v in vendas)
        {
            foreach (var h in v.Cliente.Hotdogs)
            {
                if(h is Salcicha)
                    quantSalcicha++;
                else if(h is Linguiça)
                    quantLinguiça++;
                else if(h is Frango)
                    quantFrango++;
                else if(h is Bacon)
                    quantBacon++;
            }
        }

        if(quantSalcicha >= quantLinguiça && quantSalcicha >= quantFrango && quantSalcicha >= quantBacon)
            hotdog += "Salcicha";
        else if(quantLinguiça >= quantSalcicha && quantLinguiça >= quantFrango && quantLinguiça >= quantBacon)
            hotdog += "Linguiça";
        else if(quantFrango >= quantSalcicha && quantFrango >= quantLinguiça && quantFrango >= quantBacon)
            hotdog += "Frango";
        else if(quantBacon >= quantLinguiça && quantBacon >= quantFrango && quantBacon >= quantSalcicha)
            hotdog += "Bacon";

        return hotdog;
    }

    internal static float TotalDescontos(List<Venda> vendas)
    {
        float valor = 0;

        foreach (var v in vendas)
            valor += (v.PreçoSemDesconto - v.PreçoComDesconto);

        return valor;
    }

    internal static int TotalVendido(List<Venda> vendas)
    {
        return (TotalVendidoAlunos(vendas)+TotalVendidoProfessores(vendas)+TotalVendidoServidores(vendas));
    }

    internal static int TotalVendidoAlunos(List<Venda> vendas)
    {
        int quantAlunos = 0;

        foreach (var v in vendas)
            if(v.Cliente.Tipo == ECliente.ALUNO)
                foreach (var h in v.Cliente.Hotdogs)
                    quantAlunos++;


        return quantAlunos;
    }

    internal static int TotalVendidoProfessores(List<Venda> vendas)
    {
        int quantProfessores = 0;

        foreach (var v in vendas)
            if(v.Cliente.Tipo == ECliente.PROFESSOR)
                foreach (var h in v.Cliente.Hotdogs)
                    quantProfessores++;
                
        return quantProfessores;
    }

    internal static int TotalVendidoServidores(List<Venda> vendas)
    {
        int quantServidores = 0;

        foreach (var v in vendas)
            if(v.Cliente.Tipo == ECliente.SERVIDOR)
                foreach (var h in v.Cliente.Hotdogs)
                    quantServidores++;
                
        return quantServidores;
    }

    internal static float ValorArrecadado(List<Venda> vendas)
    {
        float valor = 0;

        foreach (var v in vendas)
            valor += v.PreçoComDesconto;

        return valor;
    }
}
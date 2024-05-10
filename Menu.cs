namespace HotdogShop;
public class Menu
{
    List<Venda> vendas = new List<Venda>();
    public Menu()
    {

        MenuInterface(vendas);
    }

    private void MenuInterface(List<Venda> vendas)
    {
        Console.Clear();
        Console.WriteLine("[1] Cadastrar cliente");
        Console.WriteLine("[2] Historico de vendas");
        Console.WriteLine("[3] Sair");

        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                CadastrarCliente();
                break;
            case 2:
                ImprimirVendas(vendas);
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Aplicação encerrada.");
                return;
            default:
                MenuInterface(vendas);
                break;
        }
    }

    private void CadastrarCliente()
    {
        string? name = "";
        string? id = "";
        string? entrada;

        Console.Clear();
        Console.Write("Nome: ");
        entrada = Console.ReadLine();
        if (!String.IsNullOrEmpty(entrada))
            name = entrada;
        else
        {
            Console.Clear();
            Console.WriteLine("Nome inválido");
            CadastrarCliente();
        }

        Console.Clear();
        Console.Write("Id: ");
        entrada = Console.ReadLine();
        if (!String.IsNullOrEmpty(entrada))
            id = entrada;
        else
        {
            Console.Clear();
            Console.WriteLine("Id inválido");
            CadastrarCliente();
        }

        FazerPedido(new Venda(new Aluno(name, id)));
    }

    private void FazerPedido(Venda venda)
    {
        Console.Clear();
        Console.WriteLine("Quantos cachorros-quentes você deseja?");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade > 0)
        {
            for (int i = 0; i < quantidade; i++)
            {
                EProteina proteina = new EProteina();
                EQueijo queijo = new EQueijo();
                List<EAdicionais> adicionais = new List<EAdicionais>();
                EBebida bebida = new EBebida();
                int entrada;

                Console.Clear();
                Console.Write("[1] salsicha [2] linguiça [3] frango [4] bacon");
                entrada = int.Parse(Console.ReadLine());
                if (entrada > 0 && entrada < 5)
                    proteina = (EProteina)entrada;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    FazerPedido(venda);
                }

                Console.Clear();
                Console.Write("[1] mussarela [2] prato [3] parmesão [4] coalho");
                entrada = int.Parse(Console.ReadLine());
                if (entrada > 0 && entrada < 5)
                    queijo = (EQueijo)entrada;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    FazerPedido(venda);
                }

                Console.Clear();
                Console.Write("Deseja ketchup? [1] Sim [2] Não");
                entrada = int.Parse(Console.ReadLine());
                if (entrada == 1)
                    adicionais.Add(EAdicionais.KETCHUP);

                Console.Clear();
                Console.Write("Deseja maionese ?[1] Sim [2] Não");
                entrada = int.Parse(Console.ReadLine());
                if (entrada == 1)
                    adicionais.Add(EAdicionais.MAIONESE);

                Console.Clear();
                Console.Write("Deseja ovo? [1] Sim [2] Não");
                entrada = int.Parse(Console.ReadLine());
                if (entrada == 1)
                    adicionais.Add(EAdicionais.OVO);

                Console.Clear();
                Console.Write("Deseja batata? [1] Sim [2] Não");
                entrada = int.Parse(Console.ReadLine());
                if (entrada == 1)
                    adicionais.Add(EAdicionais.BATATA_FRITA);

                Console.Clear();
                Console.Write("[1] Coca-cola [2] DelRio [3] Suco do Chaves");
                entrada = int.Parse(Console.ReadLine());
                if (entrada > 0 && entrada < 4)
                    bebida = (EBebida)entrada;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção invalida");
                    FazerPedido(venda);
                }

                venda.Aluno.Hotdogs.Add(new Hotdog(proteina, queijo, adicionais, bebida));

            }

            vendas.Add(venda);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Quantidade invalida");
            FazerPedido(venda);
        }

        Console.WriteLine("Venda realizada");
        Console.ReadKey();
        MenuInterface(vendas);
    }

    private void ImprimirVendas(List<Venda> vendas)
    {
        Console.Clear();
        foreach (var v in vendas)
        {
            Console.WriteLine(v);
        }
        Console.ReadKey();
        MenuInterface(vendas);
    }
}
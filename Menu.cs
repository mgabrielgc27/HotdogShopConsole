namespace HotdogShop;
public class Menu
{
    List<Venda> vendas = new List<Venda>();
    public Menu()
    {
        MenuInterface();
    }

    private void MenuInterface()
    {
        Console.Clear();
        Console.WriteLine("[1] Fazer venda");
        Console.WriteLine("[2] Historico de vendas");
        Console.WriteLine("[3] Sair");
        Console.WriteLine("Quantos cachorros-quentes foram vendidos no total");
        Console.WriteLine("Quantidade de cachorros-quente vendidos para alunos: ");
        Console.WriteLine("Quantidade de cachorros-quente vendidos para professores: ");
        Console.WriteLine("Quantidade de cachorros-quente vendidos para servidores: ");
        Console.WriteLine("Tipo de cachorro-quente mais vendido: ");
        Console.WriteLine("Tipo de bebida mais vendida: ");
        Console.WriteLine("Valor total arrecadado com as vendas: ");
        Console.WriteLine("Valor total de descontos: ");
        
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                FazerVenda();
                break;
            case 2:
                ImprimirVendas();
                break;
            case 3:
                Console.Clear();
                Console.WriteLine("Aplicação encerrada.");
                return;
            default:
                MenuInterface();
                break;
        }
    }

    private void FazerVenda()
    {   
        Cliente c = CadastraCliente();

        Console.Clear();
        Console.Write("Quantos cachorros-quentes você deseja? ");
        int quant = int.Parse(Console.ReadLine());
        if(quant == 0)
            FazerVenda();
        
        for (int i = 0; i < quant; i++)
        {
            Hotdog h = new Hotdog();
            Console.WriteLine("[1] Salcicha [2] Linguiça [3] Frango [4] Bacon");
            int prot = int.Parse(Console.ReadLine());
            switch (prot)
            {
                case 1:
                        h = new Salcicha();
                    break; 
                case 2:
                        h = new Linguiça();
                    break;
                case 3:
                        h = new Frango();
                    break;
                case 4:
                        h = new Bacon();
                    break;
                default:
                        FazerVenda();
                    break;
            }

            Console.WriteLine("[1] Mussarela [2] Prato [3] Parmesão [4] Coalho");
            h.Queijo = (EQueijo)int.Parse(Console.ReadLine());

            Console.WriteLine("Ketchup? [S] SIM [N] NÃO");
            if(Console.ReadLine().ToUpper() == "S")
            {
                h.Adicionais.Add(EAdicionais.KETCHUP);
            }

            Console.WriteLine("Maionese? [S] SIM [N] NÃO");
            if(Console.ReadLine().ToUpper() == "S")
            {
                h.Adicionais.Add(EAdicionais.MAIONESE);
            }

            Console.WriteLine("Ovo? [S] SIM [N] NÃO");
            if(Console.ReadLine().ToUpper() == "S")
            {
                h.Adicionais.Add(EAdicionais.OVO);
            }

            Console.WriteLine("Batata-frita? [S] SIM [N] NÃO");
            if(Console.ReadLine().ToUpper() == "S")
            {
                h.Adicionais.Add(EAdicionais.BATATA_FRITA);
            }

            Console.WriteLine("[1] Coca-cola [2] DelRio [3] Suco do chaves");
            h.Bebida = (EBebida)int.Parse(Console.ReadLine());

            c.Hotdogs.Add(h);
        }

        vendas.Add(new Venda(c));
        MenuInterface();
    }

    private Cliente CadastraCliente()
    {
        Console.Clear();
        Cliente c = new Cliente();

        Console.WriteLine("[1] Aluno [2] Professor [3] Servidor");
        int i = int.Parse(Console.ReadLine());
        if(i == 1 || i == 2 || i == 3)
            c.Tipo = (ECliente)i;
        else
            CadastraCliente();
        
        Console.Write("Nome:");
        string s = Console.ReadLine();
        if(!String.IsNullOrEmpty(s))
            c.Name = s;
        else
            CadastraCliente();
        
        Console.Write("Identificador: ");
        i = int.Parse(Console.ReadLine());
        if(i != 0)
            c.Identificador = i;
        else
            CadastraCliente();

        return c;
    }

    private void ImprimirVendas()
    {   
        Console.Clear();
        foreach (var v in vendas)
        {
            ImprimirVenda(v);
        }
        Console.ReadKey();
        MenuInterface();
    }

    private void ImprimirVenda(Venda v)
    {
        Console.WriteLine($"{v.Cliente.Tipo}: {v.Cliente.Name} - Identificador: {v.Cliente.Identificador}");
        foreach(var c in v.Cliente.Hotdogs)
        {
            Console.WriteLine($"Cachorro-quente: {c}");
            Console.Write("Ingredientes: ");
            foreach (var a in c.Adicionais)
            {
                Console.Write($"{a} ");    
            }
            Console.WriteLine($"\nBebida: {c.Bebida}");
        }
    }

}
namespace HotdogShop;

public class Venda(Aluno aluno)
{
    public Aluno Aluno { get; set; } = aluno;

    public override string ToString()
    {   
        string resp = $"{Aluno}";
        for (int i = 0; i < Aluno.Hotdogs.Count; i++)
        {
            resp += $"\n{Aluno.Hotdogs[i]}";
        }

        return resp;
    }

}
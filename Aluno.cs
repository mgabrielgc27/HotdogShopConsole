namespace HotdogShop;

public class Aluno(string ? name, string ? matricula)
{
    private List<Hotdog> hotdogs = new List<Hotdog>();
    public string ? Name { get; } = name;
    public string ? Matricula { get; } = matricula;
    public List<Hotdog> Hotdogs
    { 
        get { return hotdogs; }
        set
        {
            if (value != null)
            {
                hotdogs = value;
            }
        } 
    }

    public override string ToString()
    {
        return $"{Name}; Id: {Matricula}";
    }
}
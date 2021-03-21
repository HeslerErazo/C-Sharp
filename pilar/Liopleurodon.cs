public class Liopleurodon:ReptilesMarinos
{
    public bool Pliosauridea { get; set; }
    public string Metodo { get; set; }

    public Liopleurodon()
    {
        Pliosauridea = true;
    }
    public Liopleurodon(bool pliosauridea, string metodo)
    {
        Pliosauridea = pliosauridea;
        Metodo = metodo;
    }
}
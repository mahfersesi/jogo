namespace jogo;

public class paiclass  
{
    int Fome;
    int Sede;
    int Feliz;

    protected string Arquivo;

    public string GetArquivo()
    {
        return Arquivo;
    }

    public paiclass()

{
    Fome=10;
    Sede=10;
    Feliz=5;
}
    public void SetFome(int f)
{
    if (f <=10 || f >=0)
        Fome = f;
    else if (f > 10)
        Fome = 10;
    else
        Fome = 0;
}
    public int GetFome()
{
    return Fome;
}
    public int GetSede()
{
    return Sede;
}
    public int GetFeliz()
{
    return Feliz;
}

}


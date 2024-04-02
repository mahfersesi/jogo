namespace jogo;

public class paiclass  
{
    int Hunger;
    int Thirst;
    int Happy;

    protected string Arquivo;

    public string GetArquivo()
    {
        return Arquivo;
    }

    public paiclass()

{
    Hunger=10;
    Thirst=10;
    Happy=5;
}
    public void SetHunger(int f)
{
    if (f <=10 || f >=0)
        Hunger = f;
    else if (f > 10)
        Hunger = 10;
    else
        Hunger = 0;
}
    public int GetHunger()
{
    return Hunger;
}
    public int GetThirst()
{
    return Thirst;
}
    public int GetHappy()
{
    return Happy;
}

}


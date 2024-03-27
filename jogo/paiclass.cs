namespace jogo;

public class paiclass  
{
    int Hunger;
    int Thirst;
    int Money;

    public paiclass()

{
    Hunger=10;
    Thirst=10;
    Money=5;
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
    public int GetMoney()
{
    return Money;
}
}


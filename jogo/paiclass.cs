namespace paiclass;

public class paiclass  
{
    int hunger
    int thirst
    int money

    public paiclass()

{
    hunger=10
    thirst=10
    money=5
}
    public void SetHunger(int f)
{
    if (f <=10 || f >=0)
        hunger = f;
    else if (f > 10)
        hunger = 10;
    else
        hunger = 0;
}
    public int GetFome()
{
    return hunger;
}
}


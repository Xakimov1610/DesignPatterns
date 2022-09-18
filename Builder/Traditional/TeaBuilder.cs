namespace Builder.Traditional;

public abstract class TeaBuilder : ITeaBuilder
{
    public Tea tea;

    public void CreateTea()
    {
        tea = new Tea();
    }

    public abstract void SetTeaType();
    public abstract void SetWater();
    public abstract void SetMilk();
    public abstract void SetSugar();
    public abstract void SetLemon();
    public abstract void SetIce();
    public Tea GetTea()
    {
        return tea;
    }
}

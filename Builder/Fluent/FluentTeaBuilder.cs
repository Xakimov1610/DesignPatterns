namespace Builder.Fluent;

public abstract class FluentTeaBuilder : IFluentTeaBuilder
{
    protected Tea tea = null;
    public IFluentTeaBuilder CreateTea()
    {
        tea = new Tea();
        return this;
    }
    public abstract IFluentTeaBuilder SetTeaType();
    public abstract IFluentTeaBuilder SetWater();
    public abstract IFluentTeaBuilder SetMilk();
    public abstract IFluentTeaBuilder SetSugar();
    public abstract IFluentTeaBuilder SetLemon();
    public abstract IFluentTeaBuilder SetIce();
    public Tea GetTea()
    {
        return tea;
    }
}

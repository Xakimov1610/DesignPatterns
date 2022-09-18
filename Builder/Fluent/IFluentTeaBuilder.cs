using Builder.Traditional;

namespace Builder.Fluent;

public interface IFluentTeaBuilder
{
    IFluentTeaBuilder CreateTea();
    IFluentTeaBuilder SetTeaType();
    IFluentTeaBuilder SetWater();
    IFluentTeaBuilder SetMilk();
    IFluentTeaBuilder SetSugar();
    IFluentTeaBuilder SetLemon();
    IFluentTeaBuilder SetIce();
    Tea GetTea();
}


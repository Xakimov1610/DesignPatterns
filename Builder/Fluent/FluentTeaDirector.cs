namespace Builder.Fluent;

public class FluentTeaDirector
{
    public Tea MakeTea(FluentTeaBuilder teaBuilder)
    {
        return teaBuilder
                    .CreateTea()
                    .SetWater()
                    .SetTeaType()
                    .SetMilk()
                    .SetSugar()
                    .SetLemon()
                    .SetMilk()
                    .SetIce()
                    .GetTea();
    }
}


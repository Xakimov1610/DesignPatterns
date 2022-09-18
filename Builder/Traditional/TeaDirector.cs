namespace Builder.Traditional;

public class TeaDirector
{
    public Tea MakeTea(TeaBuilder teaBuilder)
    {
        teaBuilder.CreateTea();
        teaBuilder.SetWater();
        teaBuilder.SetTeaType();
        teaBuilder.SetMilk();
        teaBuilder.SetSugar();
        teaBuilder.SetLemon();
        teaBuilder.SetIce();

        return teaBuilder.GetTea();
    }
}


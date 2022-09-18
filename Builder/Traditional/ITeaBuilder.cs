namespace Builder.Traditional;

public interface ITeaBuilder
{
    void CreateTea();
    void SetTeaType();
    void SetWater();
    void SetMilk();
    void SetSugar();
    void SetLemon();
    void SetIce();
    Tea GetTea();
}


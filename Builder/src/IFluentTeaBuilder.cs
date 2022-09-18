﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.src;

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


using Structural_Adapter;
using Structural_Adapter.Adapters;
using StructuralDomain.Entities;

Motor motorGasolina = new MotorCombustible();
motorGasolina.Arrancar();
motorGasolina.Acelerar();
motorGasolina.Apagar();
motorGasolina.CargarCombustible();

Console.WriteLine("\n##########\n");
Motor motorDiesel = new MotorDiesel();
motorDiesel.Arrancar();
motorDiesel.Acelerar();
motorDiesel.Apagar();
motorDiesel.CargarCombustible();

Console.WriteLine("\n##########\n");
Motor motorElectric = new MotorElectricoAdapter();
motorElectric.CargarCombustible();
motorElectric.Arrancar();
motorElectric.Acelerar();
motorElectric.Apagar();

Console.ReadLine();
using System;

public class EmpresaSinFilial : Empresa
{
    public override bool AgregaFilial(Empresa filial)
    {
        return false;
    }
    
    public override double CalculaCosteMantenimiento()
    {
        return NoVehiculos * CosteUnitarioMantenimiento;
    }    
}
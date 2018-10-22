using System;

public abstract class Empresa
{
    #region snippet_Properties
    protected static double CosteUnitarioVehiculo = 5.0;
    protected int NoVehiculos;
    #endregion
        
    #region snippet_Methods
    public void AgregaVehiculo()
    {
        NoVehiculos = NoVehiculos + 1;
    }
    
    public abstract double CalculaCosteMantenimiento();
    public abstract bool AgregaFilial(Empresa filial);
    #endregion
}
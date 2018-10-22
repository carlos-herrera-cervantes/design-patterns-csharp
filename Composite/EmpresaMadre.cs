using System;
using System.Collections.Generic;

public class EmpresaMadre : Empresa
{
    #region snippet_Properties
    protected IList<Empresa> filiales = new List<Empresa>();
    #endregion
    
    #region snippet_Methods
    public override bool AgregaFilial(Empresa filial)
    {
        filiales.Add(filial);
        return true;
    }
    
    public override double CalculaCosteMantenimiento()
    {
        double coste = 0.0;
        foreach (Empresa filial in filiales)
        {
            coste = coste filial.CalculaCosteMantenimiento();
            return coste + NoVehiculos * CosteUnitarioVehiculo;
        }
    }
    #endregion
}
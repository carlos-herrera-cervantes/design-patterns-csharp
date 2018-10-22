using System;

public class Vehiculo : ObjetoBasico
{
    #region snippet_Properties
    protected string LaDescripcion;
    #endregion
    
    #region snippet_Constructor
    public Vehiculo(string descripcion)
    {
        LaDescripcion = descripcion;
    }
    #endregion
    
    #region snippet_GetDescripcion
    protected override string GetDescripcion
    {
        get
        {
            return LaDescripcion;
        }
    }
    #endregion
}
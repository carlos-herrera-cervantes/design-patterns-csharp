using System;

public class Vehiculo : Sujeto
{
    #region snippet_Properties
    protected string Descripcion;
    protected double Precio;
    #endregion
    
    #region snippet_GetSetDescripcion
    public string GetSetDescripcion
    {
        get
        {
            return Descripcion;
        }
        set
        {
            Descripcion = value;
            this.Notifica();
        }
    }
    #endregion
    
    #region snippet_GetSetPrecio
    public double GetSetPrecio
    {
        get
        {
            return Precio;
        }
        set
        {
            Precio = value;
            this.Notifica();
        }
    }
    #endregion
}
using System;

public class Modelo : ObjetoBasico
{
    #region snippet_Properties
    protected string LaDescripcion;
    protected string Nombre;
    #endregion
    
    #region snippet_Constructor
    public Modelo(string nombre, string descripcion)
    {
        LaDescripcion = descripcion;
        Nombre = nombre;
    }
    #endregion
    
    #region snippet_GetDescripcion
    protected override string GetDescripcion
    {
        get
        {
            if (LaDescripcion != null)
            {
                return "Modelo " + Nombre + " : " + LaDescripcion;
            }
            else
            {
                return null;
            }
        }
    }
    #endregion
}
using System;

public abstract class Elemento
{
    #region snippet_Properties
    protected string Descripcion;
    #endregion
        
    #region snippet_Constructor
    public Elemento(string descripcion)
    {
        Descripcion = descripcion;
    }
    #endregion
        
    #region snippet_Methods
    public bool PalabraClaveValida(string palabraClave)
    {
        return Descripcion.IndexOf(palabraClave) != -1;
    }
    #endregion
}
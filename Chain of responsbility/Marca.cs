using System;

public class Marca : ObjetoBasico
{
    #region snippet_Properties
    protected string Descripcion1;
    protected string Descripcion2;
    protected string Nombre;
    #endregion
    
    #region snippet_Constructor
    public Marca(string nombre, string descripcion1, string descripcion2)
    {
        Descripcion1 = descripcion1;
        Descripcion2 = descripcion2;
    }
    #enregion
    
    #region snippet_GetDescripcion
    protected override string GetDescripcion
    {
        get
        {
            if ((descripcion1 != null) && (descripcion2 != null))
            {
                return "Marca " + nombre + " : " + descripcion1 + " " + descripcion2;
            }
            else if (descripcion1 != null)
            {
                return "Marca " + nombre + " : " + descripcion1;
            }
            else
            {
                return null;
            }
        }
    }
    #endregion
}
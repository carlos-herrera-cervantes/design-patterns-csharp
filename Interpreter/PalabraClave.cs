using System;

public class PalabraClave : Expresion
{
    #region snippet_Properties
    protected string PalabraClave;
    #endregion
    
    #region snippet_Constructor
    public PalabraClave(string palabraClave)
    {
        PalabraClave = palabraClave;
    }
    #endregion
    
    #region snippet_Methods
    public override bool Evalua(string descripcion)
    {
        return descripcion.IndexOf(PalabraClave) != -1;
    }
    
    public static new Expresion Parsea()
    {
        Expresion resultado;
        resultado = new PalabraClave(pieza);
        SiguientePieza();
        return resultado;
    }
    #endregion
}
using System;

public abstract class OperadorBinario : Expresion
{
    #region snippet_Properties
    protected Expresion OperadorIzquierdo;
    protected Expresion OperadorDerecho;
    #ednregion
    
    #region snippet_Constructor
    public OperadorBinario(Expresion operadorIzquierdo, Expresion operadorDerecho)
    {
        OperadorIzquierdo = operadorIzquierdo;
        OperadorDerecho = operadorDerecho;
    }
    #endregion
}
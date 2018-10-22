using System;

public class OperadorO : OperadorBinario
{
    #region snippet_Constrcutor
    public OperadorO(Expresion operadorIzquierdo, Expresion operadorDerecho) : base(operadorIzquierdo, operadorDerecho) { }
    #endregion
    
    #region snippet_Methods
    public override bool Evalua(string descripcion)
    {
        return operadorIzquierdo.Evalua(descripcion) ||
        operadorDerecho.Evalua(descripcion);
    }
    
    public static new Expresion Parsea()
    {
        Expresion resultadoIzquierdo;
        Expresion resultadoDerecho;
        resultadoIzquierdo = OperadorY.Parsea();
        while ((Pieza != null) && (Pieza == "o"))
        {
            SiguientePieza();
            resultadoDerecho = OperadorY.Parsea();
            resultadoIzquierdo = new OperadorO(resultadoIzquierdo, resultadoDerecho);
        }
        return resultadoIzquierdo;
    }
    #endregion
}
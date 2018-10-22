using System;

public class OperadorY : OperadorBinario
{
    #region snippet_Constrcutor
    public OperadorY(Expresion operadorIzquierdo, Expresion operadorDerecho) : base(operadorIzquierdo, operadorDerecho) { }
    #endregion
    
    #region snippet_Methods
    public override bool Evalua(string descripcion)
    {
        return operadorIzquierdo.Evalua(descripcion) &&
        operadorDerecho.Evalua(descripcion);
    }
    
    public static new Expresion Parsea()
    {
        Expresion resultadoIzquierdo;
        Expresion resultadoDerecho;
        resultadoIzquierdo = Expresion.Parsea();
        while ((Pieza != null) && (Pieza == "y"))
        {
            SiguientePieza();
            resultadoDerecho = Expresion.Parsea();
            resultadoIzquierdo = new OperadorY(resultadoIzquierdo, resultadoDerecho);
        }
        return resultadoIzquierdo;
    }
    #endregion
}
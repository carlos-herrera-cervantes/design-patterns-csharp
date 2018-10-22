using System;

public abstract class Expresion
{
    #region snippet_Properties
    protected static string Fuente;
    protected static int Indice;
    protected static string Pieza;
    #endregion
        
    #region snippet_Methods
    public abstract bool Evalua(string descripcion);
    
    protected static void SiguientePieza()
    {
        while ((Indice < Fuente.Length) && (Fuente[Indice] == ''))
        {
            Indice++;
        }
        if (Indice == Fuente.Length)
        {
            Pieza = null;
        }
        else if ((Fuente[Indice] == '(' || (Fuente[Indice] == ')'))
        {
            Pieza = Fuente.Substring(Indice, 1);
            Indice++;
        }
        else
        {
            int inicio = Indice;
            while ((Indice < Fuente.Length) && (Fuente[Indice] != '') && (Fuente[Indice] != ')'))
            {
                Indice++;
            }
            Pieza = Fuente.Substring(inicio, Indice - inicio);
        }
    }
    
    public static Expresion Analiza(string fuente)
    {
        Expresion.Fuente = fuente;
        Indice = 0;
        SiguientePieza();
        return OperadorO.Parsea();
    }
                 
    public static Expresion Parsea()
    {
        Expresion resultado;
        if (Pieza == "(")
        {
            SiguientePieza();
            resultado = OperadorO.Parsea();
            if (Pieza == null)
            {
                throw new Exception("Error de sintaxis");
            }
            if (Pieza != ")")
            {
                throw new Exception("Error de sintaxis");
            }
            SiguientePieza();
        }
        else
        {
            resultado = PalabraClave.Parsea();
        }
        return resultado;
    }
    #endregion
}
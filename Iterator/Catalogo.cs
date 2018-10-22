using System;
using System.Collections.Generic;

public abstract class Catalogo<TElemento, TIterador>
    where TElemento : Elemento
    where TIterador : Iterador<TElemento>, new()
{
    #region snippet_Properties
    protected IList<TElemento> Contenido = new List<TElemento>();
    #endregion
        
    #region snippet_Methods
    public TIterador Busqueda(string palabraClaveConsulta)
    {
        TIterador resultado = new TIterador();
        resultado.PalabraClaveConsulta = palabraClaveConsulta;
        resultado.Contenido = contenido;
        return resultado;
    }
    #endregion
}
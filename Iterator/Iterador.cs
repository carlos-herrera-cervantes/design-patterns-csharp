using System;
using System.Collections.Generic;

public abstract class Iterador<TElemento> where TElemento : Elemento
{
    #region snippet_Properties
    public string PalabraClaveConsulta { protected get; set; }
    protected int Indice;
    public IList<TElemento> Contenido { protected get; set; }
    #endregion
    
    #region snippet_Methods
    public void Inicio()
    {
        Indice = 0;
        int tamano = Contenido.Count;
        while ((Indice < tamano) && (!Contenido[Indice].PalabraClaveValida(PalabraClaveConsulta)))
        {
            Indice++;
        }
    }
    
    public void Siguiente()
    {
        int tamano = Contenido.Count;
        Indice++;
        while ((Indice < tamano) && (!Contenido[Indice].PalabraClaveValida(PalabraClaveConsulta)))
        {
            Indice++;
        }
    }
    
    public TElemento Item()
    {
        if (Indice < Contenido.Count)
        {
            return Contenido[Indice];
        }
        else
        {
            return null;
        }
    }
    #enregion
}
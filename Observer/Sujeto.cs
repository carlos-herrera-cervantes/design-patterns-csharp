using System;
using System.Collections.Generic;

public abstract class Sujero
{
    #region snippet_Properties
    protected IList<IObservador> Observadores = new List<IObservador>();
    #endregion
        
    #region snippet_Methods
    public void Agrega(IObservador observador)
    {
        Observadores.Add(observador);
    }
    
    public void Suprime(IObservador observador)
    {
        Observadores.Remove(observador);
    }
    
    public void Notifica()
    {
        foreach (IObservador observador in Observadores)
        {
            observador.Actualiza();
        }
    }
    #endregion
}
using System;

public abstract class Pedido
{
    protected double Importe;

    #region Constructor
    public Pedido(double importe)
    {
        Importe = importe;
    }
    #endregion
    
    #region Métodos
    public abstract bool Valida();
    public abstract void Paga();
    #endregion
}
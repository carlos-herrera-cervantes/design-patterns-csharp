using System;

public class PedidoContado: Pedido
{
    #region Constructor
    public PedidoContado(double importe) : base(importe) 
    {
    }
    #endregion

    #region Métodos
    public override void Paga()
    {
        Console.WriteLine("El pago del pedido por importe de: " + importe + " se ha realizado.");
    }

    public override bool Valida()
    {
        return true;
    }
    #endregion
}
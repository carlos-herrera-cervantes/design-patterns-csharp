using System;

public class PedidoCredito : Pedido
{
    #region Constructor
    public PedidoCredito(double importe) : base(importe) {}
    #endregion

    #region Métodos
    public override void Paga()
    {
        Console.WriteLine("El pago del pedido a crédito de: " + importe + " se ha realizado.");
    }

    public override bool Valida()
    {
        return (importe >= 1000.0) && (importe <= 5000.0);
    }
    #endregion
}
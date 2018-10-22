using System.Collections.Generic;

public class ClienteCredito : ClienteCredito
{
    #region Métodos
    protected override Pedido CreaPedido(double importe)
    {
        return new PedidoCredito(importe);
    }
    #endregion
}
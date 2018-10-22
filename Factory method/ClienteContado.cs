using System.Collections.Generic;

public class ClienteContado : Cliente
{
    #region Métodos
    protected override Pedido CreaPedido(double importe)
    {
        return new PedidoContado(importe);
    }
    #endregion
}
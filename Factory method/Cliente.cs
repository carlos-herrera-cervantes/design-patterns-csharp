using System.Collections.Generic;

public abstract class Cliente
{
    #region Propiedades
    protected IList<Pedido> pedidos = new List<Pedido>();
    #endregion

    #region Métodos
    protected abstract Pedido CreaPedido(double importe);

    public void NuevoPedido(double importe)
    {
        Pedido pedido = this.CreaPedido(importe);
        if (pedido.Valida())
        {
            pedido.Paga();
            pedidos.Add(pedido);
        }
    }
    #endregion
}
using System;

public class PedidoEntregado : EstadoPedido
{
    #region snippet_Constructor
    public PedidoEntregado(Pedido pedido) : base(pedido) { }
    #endrgion
    
    #region snippet_Methods
    public override void AgregaProducto(Producto producto) { }
    
    public override void Borra() { }
    
    public override void SuprimeProducto(Producto producto) { }
    
    public override EstadoPedido EstadoSiguiente()
    {
        return this;
    }
    #endregion
}
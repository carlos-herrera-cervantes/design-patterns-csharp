using System;

public class PedidoValidado : EstadoPedido
{
    #region snippet_Constructor
    public PedidoValidado(Pedido pedido) : base(pedido) { }
    #endregion
    
    #region snippet_Methods
    public override void AgregaProducto(Producto producto) { }
    
    public override void Borra()
    {
        pedido.Productos.Clear();
    }
    
    public override void SuprimeProducto(Producto producto) { }
    
    public override EstadoPedido EstadoSiguiente()
    {
        return new PedidoEntregado(pedido);
    }
    #endregion
}
using System;

public class PedidoEnCurso : EstadoPedido
{
    #region snippet_Constrcutor
    public PeidoEnCurso(Pedido pedido) : base(pedido) { }
    #endregion
    
    #region snippet_Methods
    public override void AgregaProducto(Producto producto)
    {
        pedido.Productos.Add(producto);
    }
    
    public override void Borra()
    {
        pedido.Productos.Clear();
    }
    
    public override void SuprimeProducto(Producto producto)
    {
        pedido.Productos.Remove(producto);
    }
    
    public override EstadoPedido EstadoSiguiente()
    {
        return new PedidoValidado(pedido);
    }
    #endregion
}
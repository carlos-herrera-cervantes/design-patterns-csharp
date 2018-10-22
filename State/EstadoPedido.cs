using System;

public abstract class EstadoPedido
{
    #region snippet_Properties
    protected Pedido pedido;
    #endregion
        
    #region snippet_Constructor
    public EstadoPedido(Pedido pedido)
    {
        this.pedido = pedido;
    }
    #endregion
        
    #region snippet_Methods
    public abstract void AgregaProducto(Producto producto);
    public abstract void Borra();
    public abstract void SuprimeProducto(Producto producto);
    public abstract EstadoPedido EstadoSiguiente();
    #endregion
}
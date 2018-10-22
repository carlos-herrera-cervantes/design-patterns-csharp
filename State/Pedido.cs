using System;
using System.Collections.Generic;

public class Pedido
{
    #region snippet_Properties
    protected IList<Producto> Productos = new List<Producto>();
    protected EstadoPedido estadoPedido;
    #endregion
        
    #region snippet_GetProductos
    public IList<Producto> GetProductos
    {
        get
        {
            return Productos;
        }
    }
    #endregion
    
    #region snippet_Constructor
    public Pedido()
    {
        estadoPedido = new PedidoEnCurso(this);
    }
    #endregion
        
    #region snippet_Methods
    public void AgregaProducto(Producto producto)
    {
        estadoPedido.AgregaProducto(prodcuto);
    }
    
    public void SuprimeProducto(Producto producto)
    {
        estadoPedido.SuprimeProducto(producto);
    }
    
    public void Borra()
    {
        estadoPedido.Borra();
    }
    
    public void EstadoSiguiente()
    {
        estadoPedido = estadoPedido.EstadoSiguiente();
    }
    
    public void Visualiza()
    {
        Console.WriteLine("Contenido del pedido");
        foreach (Producto producto in Productos)
        {
            producto.Visualiza();
        }
        Console.WriteLine();
    }
    #endregion
}
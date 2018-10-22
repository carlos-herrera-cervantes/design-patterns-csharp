using System;

public class Principal
{
    static void Main(string[] args)
    {
        Pedido pedidoEspana = new PedidoEspana();
        pedidoEspana.SetImporteSinIVA(10000);
        pedidoEspana.CalculaPrecioConIVA();
        pedidoEspana.Viualiza();
        
        Pedido pedidoLuxemburgo = new PedidoLuxemburgo();
        pedidoLuxemburgo.SetImporteSinIVA(10000);
        pedidoLuxemburgo.CalculaPrecioConIVA();
        pedidoLuxemburgo.Viualiza();
    }
}
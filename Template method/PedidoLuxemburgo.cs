using System;

public class PedidoLuxemburgo : Pedido
{
    protected override void CalculaIVA()
    {
        ImporteIVA = ImporteSinIVA * 0.15;
    }
}
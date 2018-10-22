using System;

public class PedidoEspana : Pedido
{
    protected override void CalculaIVA()
    {
        ImporteIVA = ImporteSinIVA * 0.18;
    }
}
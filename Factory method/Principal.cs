using System;

public class Principal
{
    static void Main(string[] args)
    {
        Cliente cliente;
        cliente = new ClienteContado();
        cliente.NuevoPedido(2000.0);
        cliente.NuevoPedido(10000.0);
        cliente = new ClienteCredito();
        cliente.NuevoPedido(2000.0);
        cliente.NuevoPedido(10000.0);
    }
}
using System;

public class ContructorDocumentacionVehiculoHTML : ConstructorDocumentacionVehiculo
{
    public ConstructorDocumentacionVehiculoHTML()
    {
        documentacion = new DocumentacionHTML();
    }
    
    public override void ContruyeSolicitudPedido(string nombreCliente)
    {
        string documento;
        documento = "<HTML>Solicitud de pedido cliente:" + nombreCliente + "</HTML>";
        documentacion.AgregaDocumento(documento);
    }
    
    public override ContruyeSolitudMatriculacion(string nombreSolicitante)
    {
        string documento;
        documento = "<HTML>Solicitud de matriculación solicitante:" + nombreSolicitante + "</HTML>";
        documentacion.AgregaDocumento(documento);
    }
}
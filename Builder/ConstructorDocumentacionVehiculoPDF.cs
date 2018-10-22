using System;

public class ContructorDocumentacionVehiculoPDF : ConstructorDocumentacionVehiculo
{
    public ConstructorDocumentacionVehiculoPDF()
    {
        documentacion = new DocumentacionHPDF();
    }
    
    public override void ContruyeSolicitudPedido(string nombreCliente)
    {
        string documento;
        documento = "<PDF>Solicitud de pedido cliente:" + nombreCliente + "</PDF>";
        documentacion.AgregaDocumento(documento);
    }
    
    public override ContruyeSolitudMatriculacion(string nombreSolicitante)
    {
        string documento;
        documento = "<PDF>Solicitud de matriculación solicitante:" + nombreSolicitante + "</PDF>";
        documentacion.AgregaDocumento(documento);
    }
}
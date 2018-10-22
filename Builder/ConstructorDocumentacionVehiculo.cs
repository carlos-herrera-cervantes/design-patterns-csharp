using System;

public abstract class ContructorDocumentacionVehiculo
{
    protected Documentacion documentacion;
    
    public abstract void ContruyeSolicitudPedido(string nombreCliente);
    
    public abstract void ContruyeSolicitudMatriculacion(string nombreSolicitante);
    
    public Documentacion Resultado()
    {
        return documentacion;
    }
}
using System;

public class Vendedor
{
    protected ConstructorDocumentacionVehiculo Constructor;
    
    public Vendedor(ConstructorDocumentacionVehiculo constructor)
    {
        Constructor = constructor;
    }
    
    public Documentacion Construye(string nombreCliente)
    {
        Constructor.ConstruyeSolicitudPedido(nombreCliente);
        Constructor.ConstruyeSolicitudMatriculacion(nombreCliente);
        Documentacion documentacion = Constructor.Resultado();
        return documentacion;
    }
}

using System;

public class Principal
{
    static void Main(string[] args)
    {
        DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
        documentacionEnBlanco.Incluye(new OrdenDePedido());
        documentacionEnBlanco.Incluye(new CertificadoSesion());
        documentacionEnBlanco.Incluye(new SolicitudMatriculacion());

        DocumentacionCliente documentacionCliente1 = new DocumentacionCliente("Carlos");
        DocumentacionCliente documentacionCliente2 = new DocumentacionCliente("Ruth");
        documentacionCliente1.Visualiza();
        documentacionCliente2.Visualiza();
    }
}
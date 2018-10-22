using System;

public class CertificadoSesion : Documento
{
    #region Métodos
    public override void Visualiza()
    {
        Console.WriteLine("Muestra el certificado de sesión: " + contenido);
    }

    public override void Imprime()
    {
        Console.WriteLine("Imprime el certificado de sesión: " + contenido);
    }
    #endregion
}
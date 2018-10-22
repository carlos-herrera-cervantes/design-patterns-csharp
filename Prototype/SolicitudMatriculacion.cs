using System;

public class SolicitudMatriculacion : Documento
{
    #region Métodos
    public override void Visualiza()
    {
        Console.WriteLine("Muestra la solicitud de matriculación: " + contenido);
    }

    public override void Imprime()
    {
        Console.WriteLine("Imprime la solicitud de matriculación: " + contenido);
    }
    #endregion
}
using System;
using System.Collections.Generic;

public abstract class Documentacion
{
    protected IList<string> Contenido = new List<string>();
    
    public abstract void AregaDocumento(string documento);
    public abstract void Imprime();
}
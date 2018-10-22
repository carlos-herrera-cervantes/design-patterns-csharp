using System;
using System.Collections.Generic;

public class DocumentacionCliente : Documentacion
{
    #region Constructor
    public DocumentacionCliente(string informacion)
    {
        documentos = new List<Documento>();
        DocumentacionEnBlanco documentacionEnBlanco = DocumentacionEnBlanco.Instance();
        IList<Documento> documentosEnBlanco = documentacionEnBlanco.documentos;

        foreach (var documento in documentosEnBlanco)
        {
            Documento copiaDocumento = documento.Duplica();
            copiaDocumento.Rellena(informacion);
            documentos.Add(copiaDocumento);
        }
    }
    #endregion

    #region Métodos
    public void Visualiza()
    {
        foreach (var documento in documentos)
        {
            documento.Visualiza();
        }
    }

    public void Imprime()
    {
        foreach (var documento in documentos)
        {
            documento.Imprime();
        }
    }
    #endregion
}
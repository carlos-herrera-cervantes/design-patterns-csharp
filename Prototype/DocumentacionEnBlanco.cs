using System.Collections.Generic;

public class DocumentacionEnBlanco : Documentacion
{
    #region Propiedades
    private static DocumentacionEnBlanco _instance = null;
    #endregion

    #region Constructor
    private DocumentacionEnBlanco()
    {
        documentos = new List<Documento>();
    }
    #endregion

    #region Métodos
    public static DocumentacionEnBlanco Instance()
    {
        if (_instance == null)
        {
            _instance = new DocumentacionEnBlanco();
        }

        return _instance;
    }

    public void Incluye(Documento doc)
    {
        documentos.Add(doc);
    }

    public void Excluye(Documento doc)
    {
        documentos.Add(doc);
    }
    #endregion
}
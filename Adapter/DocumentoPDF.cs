using System;

public class DocumentoPDF : Documento
{
    #region Propiedades
    protected ComponentePDF herramientaPDF = new ComponentePDF();
    public string Contenido
    {
        set
        {
            herramientaPDF.PDFFijaContenido(value);
        }
    }
    #endregion
    
    #region Métodos
    public void Dibuja()
    {
        herramientaPDF.PDFPreparaVisualizacion();
        herramientaPDF.PDFRefresca();
        herramientaPDF.PDFFinalizaVisualizacion();
    }
    
    public void Imprime()
    {
        herramientaPDF.PDFEnviaImpresora();
    }
    #endregion
}
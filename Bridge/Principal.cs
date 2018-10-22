using System;

public class Principal
{
    static void Main(string[] args)
    {
        FormularioMatriculacionPortugal formulario1 = new FormularioMatriculacionPortugal(new FormularioHTMLImplementacion());
        formulario1.Visualiza();
        if (formulario1.AdministraZona())
        {
            formulario1.GeneraDocumento();
        }
        Console.WriteLine();
        FormularioMatriculacionEspana formulario2 = new FormularioMatriculacionEspana(new FormularioAppletImplementacion());
        formulario2.Visualiza();
        if (formulario2.AdministraZona())
        {
            formulario2.GeneraDocumento();
        }
    }
}
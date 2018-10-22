using System;

public class Principal
{
    static void Main(string[] args)
    {
        Documento documento1;
        documento1 = new DocumentoHTML();
        documento1.Contenido = "Hola";
        documento1.Dibuja();
        Console.WriteLine();
        Documento documento2;
        documento2 = new DocumentoPDF();
        documento2.Contenido = "Hola de nuevo";
        documento2.Dibuja();
    }
}
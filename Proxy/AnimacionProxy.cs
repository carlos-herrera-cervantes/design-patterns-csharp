using System;

public class AnimacionProxy : Animacion
{
    #region snippet_Variables
    protected Video video = null;
    protected string foto = "mostrar la foto";
    #endregion
    
    #region snippet_Methods
    public void Clic()
    {
        if (video == null)
        {
            video = new Video();
            video.Carga();
        }
        video.Reproduce();
    }
    
    public void Dibuja()
    {
        if (video != null)
        {
            video.Dibuja();
        }
        else
        {
            Dibuja(foto);
        }
    }
    
    public void Dibuja(string foto)
    {
        Console.WriteLine(foto);
    }
    #endregion
}
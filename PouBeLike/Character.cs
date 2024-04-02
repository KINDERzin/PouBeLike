namespace PouBeLike;

public class Character
{
    double Sede;
    double Fome;
    double Felicidade;
    protected string FotoPersonagem; 

//------------------------------------------------------------

    public Character()
    {
        Sede = 0;
        Fome = 0;
        Felicidade = 0;
    }

//------------------------------------------------------------

    public string GetArquivo()
    {
        return FotoPersonagem;
    }
    
//------------------------------------------------------------



}
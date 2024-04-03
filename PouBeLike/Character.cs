namespace PouBeLike;

public class Character
{
    double Sede;
    double Fome;
    double Felicidade;
    protected string FotoPersonagem; 
    protected string NomePersonagem;

//------------------------------------------------------------

    public Character()
    {
        Sede = 0;
        Fome = 0;
        Felicidade = 0;


    }

//------------------------------------------------------------

    public void SetSede(double s)
    {
        if(s < 0)
            Sede = 0;

        else if(s > 1)
            Sede = 1;

        else
            Sede = s;
    }

    public void SetFome(double f)
    {
        if(f < 0)
            Fome = 0;
        
        else if (f > 1)
            Fome = 1;
        
        else  
            Fome = f;
    }

    public void SetFelicidade(double fe)
    {
        if(fe < 0)
            Felicidade = 0;
        
        else if(fe > 1)
            Felicidade = 1;

        else
            Felicidade = fe;
    }

//------------------------------------------------------------

    public double GetSede()
    {
        return Sede;
        
    }

    public double GetFome()
    {
        return Fome;
    }

    public double GetFelicidade()
    {
        return Felicidade;
    }

//------------------------------------------------------------

    public string GetArquivo()
    {
        return FotoPersonagem;
    }
    
//------------------------------------------------------------

    public string GetNomePersonagem()
    {
        return NomePersonagem;
    }

//------------------------------------------------------------



}
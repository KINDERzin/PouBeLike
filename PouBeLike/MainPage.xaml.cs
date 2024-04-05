namespace PouBeLike;

public partial class MainPage : ContentPage
{
	Capybara SirCapivaldo;
	Orangotango Orengotengo;
	Duck Douglas; 
	Character Atual;

	public MainPage()
	{
		InitializeComponent();
	
//------------------------------------------------------------

		var timer = Application.Current.Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromSeconds(1);
		timer.Tick += (s, e) => PassouTempo();
		timer.Start();

//------------------------------------------------------------

		SirCapivaldo = new Capybara();
		Orengotengo = new Orangotango();
		Douglas = new Duck();

//------------------------------------------------------------


		Atual = SirCapivaldo;
		ImagemAnimal.Source = Atual.GetArquivo();
		LabelNome.Text = Atual.GetNomePersonagem();

//------------------------------------------------------------


		Atual.SetSede(0.5);
		Atual.SetFome(0.5);
		Atual.SetFelicidade(0.5);

	}

//------------------------------------------------------------

	void PassouTempo()
	{
		Atual.SetFome(Atual.GetFome() - 0.01);
		BarraFome.Progress = Atual.GetFome();

		Atual.SetSede(Atual.GetSede() - 0.0001);
		BarraSede.Progress = Atual.GetSede();

		Atual.SetFelicidade(Atual.GetFelicidade() - 0.0001);
		BarraFelicidade.Progress = Atual.GetFelicidade();

		SirCapivaldo.SetFome(SirCapivaldo.GetFome() - 0.01);
		SirCapivaldo.SetSede(SirCapivaldo.GetSede() - 0.0001);
		SirCapivaldo.SetFelicidade(SirCapivaldo.GetFelicidade() - 0.0001);

		Orengotengo.SetFome(Orengotengo.GetFome() - 0.01);
		Orengotengo.SetSede(Orengotengo.GetSede() - 0.0001);
		Orengotengo.SetFelicidade(Orengotengo.GetFelicidade() - 0.0001);

		Douglas.SetFome(Douglas.GetFome() - 0.01);
		Douglas.SetSede(Douglas.GetSede() - 0.0001);
		Douglas.SetFelicidade(Douglas.GetFelicidade() - 0.0001);
	}

//------------------------------------------------------------

	private void ClicouBotaoSetaDireita(object sender, EventArgs args) 
	{
		if(Atual == SirCapivaldo)
			Atual = Orengotengo;
		
		else if(Atual == Orengotengo)
			Atual = Douglas;

		else if(Atual == Douglas)
			Atual = SirCapivaldo;

		
		
		ImagemAnimal.Source = Atual.GetArquivo();
		LabelNome.Text = Atual.GetNomePersonagem();

	}

	private void ClicouBotaoSetaEsquerda(object sender, EventArgs args) 
	{
		if(Atual == SirCapivaldo)
			Atual = Douglas;
		
		else if(Atual == Douglas)
			Atual = Orengotengo;

		else if(Atual == Orengotengo)
			Atual = SirCapivaldo;
		
		ImagemAnimal.Source = Atual.GetArquivo();
		LabelNome.Text = Atual.GetNomePersonagem();
		BarraFome.Progress = Atual.GetFome();
		BarraSede.Progress = Atual.GetSede();
		BarraFelicidade.Progress = Atual.GetFelicidade();
	}

//------------------------------------------------------------

	void AtualizarProgresso()
	{
		BarraFome.Progress = Atual.GetFome();
		BarraSede.Progress = Atual.GetSede();
		BarraFelicidade.Progress = Atual.GetFelicidade();
	}

//------------------------------------------------------------

	private void ClicouBotaoComida(object sender, EventArgs args) 
	{
		Atual.SetFome(Atual.GetFome() + 0.1);
		BarraFome.Progress = Atual.GetFome();
	}

//------------------------------------------------------------

	private void ClicouBotaoAgua(object sender, EventArgs args) 
	{
		Atual.SetSede(Atual.GetSede() + 0.1);
		BarraSede.Progress = Atual.GetSede();
	}

//------------------------------------------------------------

	private void ClicouBotaoBrincar(object sender, EventArgs args) 
	{
		Atual.SetFelicidade(Atual.GetFelicidade() + 0.1);
		BarraFelicidade.Progress = Atual.GetFelicidade();

	}
}


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
		
		SirCapivaldo = new Capybara();
		Orengotengo = new Orangotango();
		Douglas = new Duck();

		Atual = SirCapivaldo;

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
	}

//------------------------------------------------------------

	private void ClicouBotaoComida(object sender, EventArgs args) 
	{
		
	}

//------------------------------------------------------------

	private void ClicouBotaoAgua(object sender, EventArgs args) 
	{
		
	}

//------------------------------------------------------------

	private void ClicouBotaoBrincar(object sender, EventArgs args) 
	{
		
	}
}


namespace jogo;

public partial class MainPage : ContentPage
{
	Cavalo cavalo;
	Cavalo fome;
	public MainPage()
	{
		InitializeComponent();
		
		cavalo= new Cavalo();

		ImgCavalo.Source= cavalo.GetArquivo();
	}

	void QuandoOBotao(object sender, EventArgs args);
	{
		fome SetFome(GetFome()+0,1);
	}

}


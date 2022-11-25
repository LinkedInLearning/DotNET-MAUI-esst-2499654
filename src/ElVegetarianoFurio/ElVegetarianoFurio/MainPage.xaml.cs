namespace ElVegetarianoFurio;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;


			CounterBtn.Text = $"{count} Mal geklickt";


		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


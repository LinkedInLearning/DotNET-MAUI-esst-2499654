namespace ElVegetarianoFurio.Menu;

public partial class CategoriesPage : ContentPage
{
    private readonly CategoriesViewModel _viewModel;

    public CategoriesPage(CategoriesViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }


    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        await _viewModel.InitializeAsync();
        base.OnNavigatedTo(args);
    }
}
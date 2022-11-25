namespace ElVegetarianoFurio.Profile;

public partial class ProfilePage : ContentPage
{
    private ProfileViewModel _viewModel;

    public ProfilePage()
	{
		InitializeComponent();
		BindingContext = _viewModel =  new ProfileViewModel();
	}

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        _viewModel.Initialize();
    }

}